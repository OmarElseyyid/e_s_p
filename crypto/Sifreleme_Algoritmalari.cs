using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace crypto
{
    public static class Sifreleme_Algoritmalari
    {

		// SHA256 slgorithm --------------------------------------------------------
        // From string to SHA256 without key
        public static string ToSHA256(string s)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));


            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        
        // SHA256 algorithm with key 
        public static string Encrypt(string key, string data)
        {
            string encData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                encData = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return encData;
        }
        public static string Decrypt(string key, string data)
        {
            string decData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                decData = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return decData;
        }

        private static byte[][] GetHashKeys(string key)
        {
            byte[][] result = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(key);
            byte[] rawIV = enc.GetBytes(key);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }

        private static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt =
                            new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        private static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt =
                            new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }


		// SPN16  slgorithm --------------------------------------------------------

		// From string to SPN16 algorithm without key
		public static string ToSPN16(string plaintext)
        {
			string ciphertext;
            var key = "Denememe";
            byte[] keys = new byte[64]; //key for key scheduling algorithm
            byte[,] roundkey = new byte[5, 16]; //key for rounds of spn
            
            int x; // temp variable
            byte t; // temp variable

            int i,j,k,z,y; //looping variables

            byte[,] bitplain = new byte[300,8]; //plaintext in binary form
            byte[,] bitcipher = new byte[300,8]; //ciphertext in binary form
            
            byte[] round = new byte[16]; //for plaintext

			// converting key into binary
			z = 0;
            for (i = 0; i < key.Length; i++)
            {
				x = (int)key[i];
               
                for (j = z+7; j >= z; j--)
                {
					if (x % 2 == 1)
					{
						keys[j] = 1;
					}
					else
					{
						keys[j] = 0;
					}
					x /= 2;
				}
				z += 8;
			}

			
			//taking round keys into diffrent arrays
			z = 0;
			for (i = 0; i < 5; i++)
			{
				y = 0;
				for (j = z; j < z + 16; j++)
				{
					roundkey[i,y] = keys[j];
					y++;
				}
				z += 4;
			}


			//remove space
			plaintext = plaintext.Replace("\\s", "");

			if (plaintext.Length % 2 == 1)
			{
				plaintext  +=  " ";
			}


			//converting plaintext into binary			

			for (i = 0; i < plaintext.Length; i++)
			{
				x = (int)plaintext[i]; //taking the ascii(unicode) value of ith character of plaintext 
				for (j = 7; j >= 0; j--)
				{
					if (x % 2 == 1)
					{
						bitplain[i, j] = 1;
					}
					else
					{
						bitplain[i, j] = 0;
					}
					x /= 2;
				}
			}


			for (i = 0; i < plaintext.Length; i += 2)
			{
				for (j = 0; j < 16; j++)
				{
					//taking 16bits at a time from plaintext
					round[j] = bitplain[i + (j / 8), j % 8];
				}
				for (k = 0; k < 4; k++)
				{
					//rounds of substitution permutation network
					for (z = 0; z < 16; z++)
					{
						//xor with the ith round key
						round[z] = (byte)(round[z] ^ roundkey[k, z]);
					}
					//substitution function from one 4 bit value to another 4 bit value
					for (z = 0; z < 16; z += 4)
					{
						if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
					}
					//permutation of all 16 bits
					t = round[1];
					round[1] = round[4];
					round[4] = t;
					t = round[2];
					round[2] = round[8];
					round[8] = t;
					t = round[3];
					round[3] = round[12];
					round[12] = t;
					t = round[6];
					round[6] = round[9];
					round[9] = t;
					t = round[7];
					round[7] = round[13];
					round[13] = t;
					t = round[11];
					round[11] = round[14];
					round[14] = t;
				}
				for (z = 0; z < 16; z++)
				{
					//xor with the 5th round key after completion of 4 rounds
					round[z] = (byte)(round[z] ^ roundkey[4, z]);
				}
				for (j = 0; j < 16; j++)
				{
					//assigning encrypted bit values to binary form of ciphertext
					bitcipher[i + (j / 8), j % 8] = round[j];
				}
			}

			ciphertext = binaryToHex(bitcipher, plaintext.Length);

			return ciphertext;
		}


		// SPN16 algorithm with key
		public static string ToSPN16_Encrypt(string plaintext, string key)
		{
			byte[] keys = new byte[64]; //key for key scheduling algorithm
			byte[,] roundkey = new byte[5, 16]; //key for rounds of spn

			int x; // temp variable
			byte t; // temp variable

			int i, j, k, z, y; //looping variables

			byte[,] bitplain = new byte[300, 8]; //plaintext in binary form
			byte[,] bitcipher = new byte[300, 8]; //ciphertext in binary form

			byte[] round = new byte[16]; //for plaintext

			z = 0;
			for (i = 0; i < key.Length; i++)
			{
				x = Convert.ToInt32(key[i]);
				for (j = z + 7; j >= z; j--)
				{
					if (x % 2 == 1)
					{
						keys[j] = 1;
					}
					else
					{
						keys[j] = 0;
					}
					x = (int)(x / 2);
				}
				z += 8;
			}

			//taking round keys into diffrent arrays
			z = 0;
			for (i = 0; i < 5; i++)
			{
				y = 0;
				for (j = z; j < z + 16; j++)
				{
					roundkey[i, y] = keys[j];
					y++;
				}
				z += 4;
			}


			//remove space
			plaintext = plaintext.Replace("\\s", "");

			if (plaintext.Length % 2 == 1)
			{
				plaintext += ' '.ToString();
			}


			//converting plaintext into binary			

			for (i = 0; i < plaintext.Length; i++)
			{
				x = Convert.ToInt32(plaintext[i]);
				//taking the ascii(unicode) value of ith character of plaintext 
				for (j = 7; j >= 0; j--)
				{
					if (x % 2 == 1)
					{
						bitplain[i, j] = 1;
					}
					else
					{
						bitplain[i, j] = 0;
					}
					x = (int)(x / 2);
				}
			}


			for (i = 0; i < plaintext.Length; i += 2)
			{
				for (j = 0; j < 16; j++)
				{
					//taking 16bits at a time from plaintext
					round[j] = bitplain[i + (j / 8), j % 8];
				}
				for (k = 0; k < 4; k++)
				{
					//rounds of substitution permutation network
					for (z = 0; z < 16; z++)
					{
						//xor with the ith round key
						round[z] = (byte)(round[z] ^ roundkey[k, z]);
					}
					//substitution function from one 4 bit value to another 4 bit value
					for (z = 0; z < 16; z += 4)
					{
						if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
					}
					//permutation of all 16 bits
					t = round[1];
					round[1] = round[4];
					round[4] = t;
					t = round[2];
					round[2] = round[8];
					round[8] = t;
					t = round[3];
					round[3] = round[12];
					round[12] = t;
					t = round[6];
					round[6] = round[9];
					round[9] = t;
					t = round[7];
					round[7] = round[13];
					round[13] = t;
					t = round[11];
					round[11] = round[14];
					round[14] = t;
				}
				for (z = 0; z < 16; z++)
				{
					//xor with the 5th round key after completion of 4 rounds
					round[z] = (byte)(round[z] ^ roundkey[4, z]);
				}
				for (j = 0; j < 16; j++)
				{
					//assigning encrypted bit values to binary form of ciphertext
					bitcipher[i + ((int)(j / 8)), j % 8] = round[j];
				}
			}

			string ciphertext = binaryToHex(bitcipher, plaintext.Length);


			return ciphertext;

		}
		public static string ToSPN16_Decrypt(string ciphertext, string key)
        {
			string plaintext = "";

			byte[] keys = new byte[64]; //key for key scheduling algorithm 8 char
			byte[,] roundkey = new byte[5,16]; //key for rounds of spn

			int x; // temp variable
			byte t; // temp variable
			char v; // temp vaiable 

			int i, j, k, z, y; //looping variables

			byte[,] bitplain = new byte[300, 8]; //plaintext in binary form
			byte[,] bitcipher = new byte[300, 8]; //ciphertext in binary form

			byte[] round = new byte[16]; //for plaintext


			// converting key into binary
			z = 0;
			for (i = 0; i < key.Length; i++)
			{
				x = (int)key[i];

				for (j = z + 7; j >= z; j--)
				{
					if (x % 2 == 1)
					{
						keys[j] = 1;
					}
					else
					{
						keys[j] = 0;
					}
					x /= 2;
				}
				z += 8;
			}

			//taking round keys into diffrent arrays
			z = 0;
			for (i = 0; i < 5; i++)
			{
				y = 0;
				for (j = z; j < z + 16; j++)
				{
					roundkey[i,y] = keys[j];
					y++;
				}
				z += 4;
			}

			//converting ciphertext into binary
			bitcipher = hexToBinary(ciphertext);

			for (i = 0; i < (ciphertext.Length / 2); i += 2)
			{
				for (j = 0; j < 16; j++)
				{
					//taking 16bits at a time from ciphertext
					round[j] = bitcipher[i + (j / 8), j % 8];
				}
				for (z = 0; z < 16; z++)
				{
					//xor with the 5th round key 
					round[z] = (byte)(round[z] ^ roundkey[4, z]);
				}
				for (k = 3; k >= 0; k--)
				{
					//rounds of substitution permutation network
					//permutation inverse of all 16 bits
					t = round[1];
					round[1] = round[4];
					round[4] = t;
					t = round[2];
					round[2] = round[8];
					round[8] = t;
					t = round[3];
					round[3] = round[12];
					round[12] = t;
					t = round[6];
					round[6] = round[9];
					round[9] = t;
					t = round[7];
					round[7] = round[13];
					round[13] = t;
					t = round[11];
					round[11] = round[14];
					round[14] = t;
					//inverse of substitution function
					for (z = 0; z < 16; z += 4)
					{
						if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 0 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 0;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 0 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 0;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 0)
						{
							round[z] = 0;
							round[z + 1] = 0;
							round[z + 2] = 0;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 0 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 0;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 0)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 0;
							round[z + 3] = 1;
						}
						else if (round[z] == 1 && round[z + 1] == 1 && round[z + 2] == 1 && round[z + 3] == 1)
						{
							round[z] = 1;
							round[z + 1] = 1;
							round[z + 2] = 1;
							round[z + 3] = 1;
						}
					}
					for (z = 0; z < 16; z++)
					{
						//xor with the ith round key
						round[z] = (byte)(round[z] ^ roundkey[k, z]);
					}
				}
				for (j = 0; j < 16; j++)
				{
					//assigning decrypted bit values to binary form of plaintext
					bitplain[i + (j / 8), j % 8] = round[j];
				}
			}
			//taking ASCII value for encrypted character and assigning it to ciphertext string
			for (i = 0; i < (ciphertext.Length / 2); i++)
			{
				x = 0;
				for (j = 0; j <= 7; j++)
				{
					x = (int)(x + (bitplain[i, j] * Math.Pow(2, (7 - j))));
				}
				v = (char)x;
				plaintext +=  v.ToString();
			}


			return plaintext;
        }


		public static string binaryToHex(byte[,] bin, int n)
		{
			int j;
			string hex = "";
			for (var z = 0; z < n; z++)
			{
				for (var i = 0; i < 2; i++)
				{
					j = 4 * i;
					if (bin[z, j] == 0 && bin[z, j + 1] == 0 && bin[z, j + 2] == 0 && bin[z, j + 3] == 0)
					{
						hex += '0';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 0 && bin[z, j + 2] == 0 && bin[z, j + 3] == 1)
					{
						hex += '1';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 0 && bin[z, j + 2] == 1 && bin[z, j + 3] == 0)
					{
						hex += '2';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 0 && bin[z, j + 2] == 1 && bin[z, j + 3] == 1)
					{
						hex += '3';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 1 && bin[z, j + 2] == 0 && bin[z, j + 3] == 0)
					{
						hex += '4';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 1 && bin[z, j + 2] == 0 && bin[z, j + 3] == 1)
					{
						hex += '5';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 1 && bin[z, j + 2] == 1 && bin[z, j + 3] == 0)
					{
						hex += '6';
					}
					else if (bin[z, j] == 0 && bin[z, j + 1] == 1 && bin[z, j + 2] == 1 && bin[z, j + 3] == 1)
					{
						hex += '7';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 0 && bin[z, j + 2] == 0 && bin[z, j + 3] == 0)
					{
						hex += '8';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 0 && bin[z, j + 2] == 0 && bin[z, j + 3] == 1)
					{
						hex += '9';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 0 && bin[z, j + 2] == 1 && bin[z, j + 3] == 0)
					{
						hex += 'a';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 0 && bin[z, j + 2] == 1 && bin[z, j + 3] == 1)
					{
						hex += 'b';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 1 && bin[z, j + 2] == 0 && bin[z, j + 3] == 0)
					{
						hex += 'c';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 1 && bin[z, j + 2] == 0 && bin[z, j + 3] == 1)
					{
						hex += 'd';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 1 && bin[z, j + 2] == 1 && bin[z, j + 3] == 0)
					{
						hex += 'e';
					}
					else if (bin[z, j] == 1 && bin[z, j + 1] == 1 && bin[z, j + 2] == 1 && bin[z, j + 3] == 1)
					{
						hex += 'f';
					}
				}
			}
			return hex;
		}

		public static byte[,] hexToBinary(string hex)
		{
			char x;
			byte[,] bin = new byte[300, 8];
			for (var i = 0; i < hex.Length; i += 2)
			{
				x = hex[i];
				if (x == '0')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == '1')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == '2')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == '3')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == '4')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == '5')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == '6')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == '7')
				{
					bin[(int)(i / 2), 0] = 0;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == '8')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == '9')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == 'a')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == 'b')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 0;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == 'c')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == 'd')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 0;
					bin[(int)(i / 2), 3] = 1;
				}
				else if (x == 'e')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 0;
				}
				else if (x == 'f')
				{
					bin[(int)(i / 2), 0] = 1;
					bin[(int)(i / 2), 1] = 1;
					bin[(int)(i / 2), 2] = 1;
					bin[(int)(i / 2), 3] = 1;
				}
				x = hex[i + 1];
				if (x == '0')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == '1')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == '2')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == '3')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == '4')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == '5')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == '6')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == '7')
				{
					bin[(int)(i / 2), 4] = 0;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == '8')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == '9')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == 'a')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == 'b')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 0;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == 'c')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == 'd')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 0;
					bin[(int)(i / 2), 7] = 1;
				}
				else if (x == 'e')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 0;
				}
				else if (x == 'f')
				{
					bin[(int)(i / 2), 4] = 1;
					bin[(int)(i / 2), 5] = 1;
					bin[(int)(i / 2), 6] = 1;
					bin[(int)(i / 2), 7] = 1;
				}
			}


			return bin;
		}


		public static byte[] ConvertToByteArray(string str, Encoding encoding)
		{
			return encoding.GetBytes(str);
		}

		public static String ToBinary(Byte[] data)
		{
			return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
		}

	}
}

