# AR-Uygulama
AR Uygulama

AR Teknolojisi ile Mobil Uygulama AR Tabanlı Mobil Uygulama Geliştirme
![image](https://github.com/buseyener/AR-Uygulama/assets/119698903/d4ef528e-ffcc-4c50-b569-3be3c3e4b77d)



Yazılım Geliştirme Labarotuvarı Proje 1 olarak bize verilen bu ödevde 32. Grup olarak ARCore teknolojisini ile bir mobil uygulama tasarladık.

Proje Özeti:

Projemizde artırılmış gerçeklik için Unity 3D ARCore teknolojisini kullandık. Unity AssetStore üzerinden indirdiğimiz BatteRoyale oyun karakterlerimizi hazırlamış olduğumuz bir zemin üzerine konumlandırdık. Oyun gibi tasarladığımız bu projede seçmiş olduğumuz iki karakter çeşitli figürler sergiliyor. Asıl karakterimiz, oluşturduğumuz script dosyası ile ekrana tıkladığımız her yere hareket ediyor. Uygulamamıza arka fon olarak bir ses dosyası ve hazırladığımız bu görselin animasyon videosunu ekledik.

Proje Geliştirme Ortamı:

Projemizi Unity Hub üzerinden geliştirdik. Unity, Unity Technologies tarafından geliştirilen, bir oyunu sıfırdan yapabilmek için gerekli olan tüm bileşenleri içeren dünyanın en popüler oyun motorlarındandır.  Farklı platformlarda kullanılabilmektedir. Windows, Mac, Linux ve mobil işletim sistemleri ile uyumlu çalışır.  Unity platformunda oluşturduğumuz script dosyalarını C# veya Javascript ile yazabiliriz. Unity Asset Store ile uygulamamızda kullanmak istediğimiz karakterlere, arka fona, müziklere, videolara vb. ekipmanlara erişebiliriz.

Proje Bilgileri:

Unity Hub üzerinden geliştirdiğimiz bu projede 3D ARCore teknolojisini kullandık. ARCore teknolojisi, geliştiricilerin artırılmış gerçeklik uygulamaları oluşturmasına olanak tanır. ARCore, konum değişikliklerini hesaplamayı yöneterek cihazın dünyanın çevresinde nerede olduğunu yorumlamak için SLAM (Eşzamanlı Yerelleştirme ve Haritalama) kullanır. ARCore, bir kamera ile çekilen fotoğraflarda görsel olarak farklı olan nesneleri tanımlayabilir. Daha sonra bu özellik noktalarından yararlanarak cihazın pozisyon hareket edip etmediğini ve yeni yerin özelliklerinin neler olduğunu belirler.

Projemizde temel olarak bazı paketler kullandık. Bunlardan kısaca bahsedecek olursak:

AR Foundation:

Unity geliştiricilerinin kullanması için bir arayüz sunar ancak AR özelliklerinin kendilerini uygulamaz.

AR Session:

Artırılmış gerçeklik (AR) deneyiminin yaşam döngüsünü kontrol eder.

AR Session Origin:

Artırılmış gerçeklik koordinatlarını Unity dünya koordinatlarına dönüştürür.

Görüntü için kullanacağımız AR Camera AR Session Origin paketinin içinde yer alır.
