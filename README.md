# e_s_p
**encryption and socket programming project with c#**

## Proje
- İlk Form anahtarsız girilen metni kullanıcının isteğine göre şifreli metne dönüştürür (SHA256 veya SPN16).
- İkinci Form Soket Progrmlama kullanarak aynı ip üzerinde bağlanan kişiler arasında mesajlaşamları. (Mesajlar kullanıcının isteğine göre SHA256 veya SPN16 ile sabit 8 karakterli anahtarla şifrelenip çözülür.)
- Üçüncü Form yine Soket Programlama kullanarak dosya alış verişi sağlar. (Dosya türleri: .txt .dat .png .gif)

## Proje Mimarisi
Kullanıcı bir sunucu veya istemci olabilir, kullanıcı her iki durumda da mesaj ve dosya gönderip alabilir. TCP protokolu kullanarak bilgisayarın ip adresi üzerinde alış veriş yapar.

## Proje Katmanları
Projede 2 adet katman vardır.
- **crypto katmanı:** proje tüm kodların barındırdığı ana katman.
- **crypto.UnitTest katmanı:** white box testleri (Unit test) için kullandığımız katman.

## Proje Resimleri 
![alt text](https://github.com/OmarElseyyid/e_s_p/blob/main/images/1.png?raw=true)
![alt text](https://github.com/OmarElseyyid/e_s_p/blob/main/images/2.png?raw=true)
![alt text](https://github.com/OmarElseyyid/e_s_p/blob/main/images/3.png?raw=true)

## Kiviyat Grafiği ve Block Histogram
![alt text](https://github.com/OmarElseyyid/e_s_p/blob/main/images/Kiviat.png?raw=true)
![alt text](https://github.com/OmarElseyyid/e_s_p/blob/main/images/histogram.png?raw=true)
