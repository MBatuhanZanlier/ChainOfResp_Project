#  Chain Of Responsibility Nedir?
Chain of Responsibility (Sorumluluk Zinciri) tasarım deseni, bir dizi nesne arasında isteği ileten ve bu nesneler arasında hiyerarşik bir zincir oluşturan bir desendir. Bu desen, bir isteği işleyebilecek nesneyi bulmak ve işleme işini bu nesneye devretmek için kullanılır. İstemci, zincirin başlangıcındaki nesneye isteği ilettikten sonra, bu nesne isteği işleyebilecek nesneyi bulana kadar zincir boyunca ilerler.

### Bu desenin temel prensipleri şunlardır:

- Sorumluluk Zinciri Oluşturma: Farklı nesnelerin hiyerarşik bir şekilde bir araya gelerek bir işlemi gerçekleştirmesini sağlar. Her nesne, isteği işleyebilecek kapasiteye sahip olmalıdır.

- Nesneler Arası Bağımlılık: Bir nesne, işi kendisi halledebileceği durumdaysa işlemi sonlandırır veya bir sonraki nesneye devreder. Bu şekilde nesneler arası bağımlılık azalır ve esneklik sağlanır.

- Tek Sorumluluk İlkesi (Single Responsibility Principle): Her bir nesne yalnızca belirli bir işlevi yerine getirmelidir. Zincirdeki her bir nesne, yalnızca kendi yetki alanındaki işlemleri gerçekleştirmelidir.

- İstek İşleme Sırası: İstemci tarafından gönderilen istek, zincirdeki nesnelerin sırasıyla işlenmesiyle sonuçlanır. Her bir nesne, isteği işleyip edemeyeceğini kontrol eder ve gerekirse bir sonraki nesneye iletir.

- Esneklik ve Genişletilebilirlik: Zincirde yeni bir nesne eklemek veya mevcut nesneleri değiştirmek, sistemin davranışını kolayca değiştirmenizi sağlar. 
## Proje Hakkında  
Bu projede bir küçük banka kredi işlemi senaryosu üstüne kurulmuştur. Müşteri gelip istediği tutarda kredi çekmek için çekeceği kredi miktranını bankaya iletiyor ve banka çalışanlarının  ödeme yapma miktarları oluyor  ve müşteriyi ilgili çalışana yönlendirmiş oluyor. 
#### Örneğin; 
Müşteri 75.000.00  TL lik bir  kredi çekme işlemi gerçekleştirmek istiyor. Veznadar sadece 1 Tl ile 80.000.00 ödeme limiti olduğundan dolayı bu işlemi veznadar gerçekleştirecektir.  Eğerk ki müşteri 80.000 Tl lik giriş yapmış olsaydı eğer burada 80.000.00 tl ile 150.000.00 tl işlemi yapacak Şube Müdür yardımcısı bu işlemi gerçekleştirmiş olacaktı. 
## Proje Hakkında Görseller 
![Ekran Görüntüsü (120)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/ed230e7f-2a77-413e-af20-20687aadf50c)
![Ekran Görüntüsü (117)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/63cfb976-30e2-4027-8005-13e1ae60949d)
![Ekran Görüntüsü (121)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/d21209aa-bf11-4d7c-8138-e04d0fe3dc1e)
![Ekran Görüntüsü (119)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/1ac8c4d5-0943-4599-850b-1f180bad274b)
![Ekran Görüntüsü (114)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/b3b1eb1b-f24a-4408-a4a3-f416c6782b13)
![Ekran Görüntüsü (116)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/b3777959-51c2-4df9-9bcb-5dcb4a216dd0)
![Ekran Görüntüsü (115)](https://github.com/MBatuhanZanlier/ChainOfResp_Project/assets/158502460/f3453be8-1333-462c-8eaa-50d6fa8d0c09)
