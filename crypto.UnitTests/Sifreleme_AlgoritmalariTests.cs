using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace crypto.UnitTests
{
    [TestClass]
    public class Sifreleme_AlgoritmalariTests
    {
        [TestMethod]
        public void ToSHA256_BoslukKabulEtmesi_ReturnsSifrelenmisBosluk()
        {
            // Arrange
            // the class is static no need to object 
            // Act
            var res = Sifreleme_Algoritmalari.ToSHA256(" ");
            // Assert
            Assert.AreEqual("36a9e7f1c95b82ffb99743e0c5c4ce95d83c9a430aac59f84ef3cbfab6145068", res);
        }
        [TestMethod]
        public void ToSHA256WithKey_BoslukVeAnahtarSifreleme_ResturnsSifrelenmisBosluk()
        {
            // Arrange
            // the class is static no need to object 
            // Act
            var res = Sifreleme_Algoritmalari.Encrypt("KKSDGFHG", " ");
            // Assert
            Assert.AreEqual("NKLSNix4oP4SE2QoBzWWnw==", res);
        }
        [TestMethod]
        public void ToSHA256WithKey_BoslukVeAnahtarDesifreleme_ResturnsDesifreEdilmisBosluk()
        {
            // Arrange
            // the class is static no need to object 
            // Act
            var res = Sifreleme_Algoritmalari.Decrypt("KKSDGFHG", "NKLSNix4oP4SE2QoBzWWnw==");
            // Assert
            Assert.AreEqual(" ", res);
        }
        [TestMethod]
        public void ToSPN16_SayiSifrelemesi_ReturnsSifrelenmisSayi()
        {
            // Arrange
            // the class is static no need to object 
            // Act
            var res = Sifreleme_Algoritmalari.ToSPN16("15450");
            // Assert
            Assert.AreEqual("9e4df76f9f05", res);
        }
        [TestMethod]
        public void ToSPN16WithKey_SayiVeAnahtarSifrelemesi_ReturnsSifrelenmisSayi()
        {
            // Arrange
            // the class is static no need to object 
            // Act
            var res = Sifreleme_Algoritmalari.ToSPN16_Encrypt("15450", "KKSDGFHG");
            // Assert
            Assert.AreEqual("20167fa7e5d4", res);
        }
    }
}
