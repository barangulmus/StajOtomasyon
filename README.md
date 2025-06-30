# Staj Otomasyon Programı

## Proje Hakkında

Bu program, meslek liselerinde staj süreçlerini yönetmek amacıyla geliştirilmiş bir Windows masaüstü uygulamasıdır. Temel amacı, öğrenci, öğretmen ve işletme bilgilerini merkezi bir yerde tutmak ve staj dönemlerine (Kış, Yaz, MESEM) ait gerekli belgelerin (raporlar, çizelgeler, formlar) otomatik olarak doldurulup kolayca yazdırılmasını veya dijital olarak dışa aktarılmasını sağlamaktır. Ayrıca, basılan belgelerin teslim takibini kolaylaştırmak için QR kod entegrasyonu da bulunmaktadır.
## Program Neler Yapabilir?

Staj Otomasyon Programı aşağıdaki ana işlevleri sunar:

*   **Kayıt Yönetimi:** Öğrenci, Koordinatör Öğretmen ve İşletme bilgilerini ekleyebilir, düzenleyebilir ve silebilirsiniz.
*   **Veri Listeleme ve Sorgulama:** Kayıtlı tüm verileri listeleyebilir, farklı kriterlere (ad, sınıf, işletme, alan, il/ilçe vb.) göre filtreleyebilir ve sıralayabilirsiniz.
*   **Detay Görüntüleme:** Her bir öğrenci, öğretmen veya işletme kaydının tüm detaylarını görüntüleyebilir, ilgili kişilerle (örneğin öğrencinin öğretmeni veya işletmesi) hızlıca ilişkili bilgilere ulaşabilirsiniz.
*   **Esnek Ayarlar:** Okulunuzun adını, eğitim öğretim yılını, kullandığınız alan ve dal isimlerini, sınıfları, sorumlu kişileri (müdür yardımcısı, müdür vb.) ve programın bazı görsel ayarlarını kendinize göre yapılandırabilirsiniz.
*   **Otomatik Belge Oluşturma:** Farklı staj dönemleri için önceden hazırlanmış Excel şablonları üzerine programdaki verileri otomatik olarak yerleştirerek belgeler oluşturur. Desteklenen belgeler:
    *   **Kış/MESEM Stajı:** Aylık/Günlük Rehberlik Raporu, Devamsızlık Çizelgesi, Not Fişi.
    *   **Yaz Stajı:** Günlük Rehberlik Rapor Formu (Haftalık Rapor), Değerlendirme Formu (Fotoğraf ekleme destekli).
*   **Çıktı Seçenekleri:** Oluşturulan belgeleri bilgisayarınıza bağlı bir yazıcıdan yazdırabilir, standart bir PDF dosyası olarak kaydedebilir veya üzerinde değişiklik yapmak isterseniz orijinal Excel formatında dışa aktarabilirsiniz.
*   **QR Kodlu Belge Takibi:** Yazdırılan belgelere eklenen özel QR kodları sayesinde, belgelerin teslim alındığını program üzerinden kolayca işaretleyip takip edebilirsiniz.
*   **Toplu Veri Aktarımı:** Hazırladığınız Excel dosyalarındaki öğrenci, öğretmen veya işletme bilgilerini programın veritabanına toplu olarak aktarabilirsiniz.

## Kurulum

Programı iki farklı yolla kurabilirsiniz:

### 1. Hazır Kurulum Dosyası ile Kurulum (Önerilir)

Bu yöntem, programı derlemeye gerek kalmadan doğrudan bilgisayarınıza kurmanızı sağlar.

1.  Aşağıdaki linkten kurulum dosyalarını içeren `.rar` dosyasını indirin:
    [Hazır Kurulum Dosyası (`setup.rar`)](https://github.com/barangulmus/StajOtomasyon/blob/main/readme/setup.rar?raw=true)
2.  İndirdiğiniz `setup.rar` dosyasını bilgisayarınızda istediğiniz bir konuma çıkarın.
3.  Çıkarılan klasörün içindeki `Setup.exe` dosyasına çift tıklayarak kurulumu başlatın ve ekrandaki adımları takip edin. Program gerekli dosyaları sisteminize kuracaktır.
4.  Kurulum tamamlandıktan sonra programı başlatabilirsiniz.

### 2. Kaynak Koddan Kurulum (Geliştiriciler İçin)

Eğer kaynak kod üzerinde değişiklik yapmak veya derleme sürecini kontrol etmek isterseniz bu yöntemi kullanabilirsiniz. Bu yöntem, Visual Studio gibi bir geliştirme ortamı gerektirir.

1.  Proje deposunu bilgisayarınıza klonlayın veya indirin.
2.  Visual Studio'da çözüm dosyasını (`.sln`) açın.
3.  Visual Studio'nun gerekli NuGet paketlerini otomatik olarak indirmesini bekleyin veya manuel olarak geri yükleyin.
4.  Çözümü derleyin (Build Solution).
5.  Derleme başarılı olduktan sonra, proje klasörünüzdeki `bin/Debug` veya `bin/Release` klasöründe bulunan çalıştırılabilir dosyayı (`.exe`) bulup çalıştırabilirsiniz.

## İlk Çalıştırma ve Yapılandırma Adımları

Programı ilk kez çalıştırdığınızda veya kurulum sonrası aşağıdaki adımları uygulamanız gerekecektir:

1.  **Veritabanı ve Klasörlerin Oluşturulması:** Program ilk açıldığında otomatik olarak gerekli veritabanını oluşturacak (sisteminizde SQL Server LocalDB yüklüyse) ve `Belgelerim\StajOtomasyon` ile `Resimler\StajOtomasyon` ana klasörleri altında belge ve fotoğraf depolamak için gerekli alt klasörleri (örneğin `Books`, `OgrenciFotograflari`, `OgretmenFotograflari`) oluşturacaktır.
2.  **Excel Şablonlarını Yerleştirme:** Belge yazdırma/dışa aktarma işlevlerinin çalışabilmesi için **Excel şablon dosyaları gereklidir**. Bu dosyalar `readme` klasörü içindeki `Books.rar` dosyasında bulunmaktadır.
    *   Aşağıdaki linkten `Books.rar` dosyasını indirin:
        [Excel Şablonları (`Books.rar`)](https://github.com/barangulmus/StajOtomasyon/blob/main/readme/Books.rar?raw=true)
    *   İndirdiğiniz `Books.rar` dosyasını çıkarın. İçinden çıkan `Yaz.xlsx` ve `Kis.xlsx` dosyalarını programın otomatik oluşturduğu klasöre kopyalayın:
        `Belgelerim\StajOtomasyon\Books\`
    *   **Bu adım kritik öneme sahiptir. Şablon dosyaları olmadan belge yazdırma/dışa aktarma özellikleri çalışmayacaktır.**
3.  **Ayarların Yapılandırılması:** Programın düzgün çalışabilmesi ve okulunuzun bilgilerine göre özelleştirilebilmesi için "Ayarlar" sekmesine gidin ve aşağıdaki temel bilgileri doldurup kaydedin:
    *   Okul Adı
    *   Eğitim Öğretim Yılı
    *   Alan ve Dal Adları (Okulunuzdaki tüm alan ve dalları ekleyin)
    *   Sınıf Adları (Okulunuzdaki tüm sınıfları ekleyin)
    *   Sorumlu Müdür, Müdür Yardımcısı ve Koordinatör Müdür Yardımcısı İsimleri
    *   Varsayılan Staj Başlangıç ve Bitiş Tarihleri
    *   Diğer gelişmiş ayarları tercihinize göre yapabilirsiniz.
    *   Bazı ayar değişikliklerinden sonra programın doğru çalışması için **programı yeniden başlatmanız gerekebilir**.

## Kullanım

Kurulum ve ilk yapılandırma adımlarını tamamladıktan sonra programı kullanmaya başlayabilirsiniz. Programın ana ekranındaki menüler ve sekmeler aracılığıyla tüm işlevlere erişebilirsiniz.

## Excel'den Veri Aktarımı

Mevcut öğrenci, öğretmen veya işletme listelerinizi programa hızlıca eklemek için "Ayarlar" sekmesi altındaki "Excel'den Aktarım" özelliğini kullanın. Excel dosyanızdaki sütunları programdaki ilgili alanlarla eşleştirerek toplu aktarım yapabilirsiniz.

## Belge Yazdırma ve QR Kod Takibi

"Yazdır" sekmesini kullanarak staj döneminize ve ihtiyacınız olan belge türüne göre (Raporlar, Devamsızlık, Not Fişi, Değerlendirme Formu) belgeleri otomatik olarak oluşturabilir ve seçtiğiniz çıktı formatına (Yazıcı, PDF, Excel) gönderebilirsiniz. Basılan belgelerdeki QR kodları, programın alt kısmındaki QR okuyucu paneli aracılığıyla okutularak teslim alındı bilgisi veritabanına kaydedilir.

---

Bu README dosyası, kullanıcıların programı indirip kurmalarına ve temel özelliklerini kullanmalarına yardımcı olacaktır. Başka sorularınız olursa çekinmeden sorabilirsiniz!
