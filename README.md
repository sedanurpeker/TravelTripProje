# TravelTripProje

**TravelTripProje**, kullanıcıların seyahat deneyimlerini paylaşabilecekleri, blog yazıları yazabilecekleri ve yorum yapabilecekleri bir web uygulamasıdır. Bu proje, **ASP.NET MVC** framework'ü kullanılarak geliştirilmiştir ve bir **admin paneli** ile **blog yönetimi, yorum yönetimi ve iletişim mesajlarını görüntüleme** gibi özellikler sunar. Seyahat tutkunları için tasarlanmış bu platform, kullanıcı dostu bir arayüze sahiptir.

## Özellikler

- **Blog Yönetimi**: Admin paneli üzerinden blog yazıları ekleyebilir, güncelleyebilir ve silebilirsiniz.
- **Yorum Yönetimi**: Kullanıcı yorumlarını listeleyebilir, düzenleyebilir ve silebilirsiniz.
- **İletişim Mesajları**: Kullanıcıların gönderdiği iletişim mesajlarını görüntüleyebilir ve silebilirsiniz.
- **Kimlik Doğrulama**: Güvenli bir login sistemi ile admin paneline erişim sağlanır.
- **Kullanıcı Dostu Arayüz**: Modern ve şık bir tasarım ile kullanıcı deneyimi ön planda tutulmuştur.

## Teknolojiler

- **Backend**: ASP.NET MVC (C#)
- **Veritabanı**: Microsoft SQL Server
- **Frontend**: HTML, CSS, JavaScript
- **Kimlik Doğrulama**: Forms Authentication
- **Diğer**: Google Maps API

## Proje Yapısı

Projenin temel dosyaları ve klasörleri:

```
📂 Controllers
 ┣  AboutController.cs        # Hakkında sayfasını yönetir.
 ┣  AdminController.cs        # Blog, yorum ve iletişim mesajlarını yönetmek için admin paneli işlemleri.
 ┣  BlogController.cs         # Blog yazılarının listelenmesi ve detaylarının gösterilmesi.
 ┣  ContactController.cs      # İletişim sayfasını ve mesajları yönetir.
 ┣  GirisYapController.cs     # Login ve logout işlemleri.
 ┗  DefaultController.cs      # Ana sayfa ve diğer statik sayfalar.

📂 Views
 ┣ 📂 Admin/                   # Admin paneli için view'lar (blog listesi, yorum listesi, vb.).
 ┣ 📂 Blog/                    # Blog yazıları ve yorumlar için view'lar.
 ┣  GirisYap/Login.cshtml    # Login sayfası.
 ┗ 📂 Default/                 # Ana sayfa ve diğer statik sayfalar.

📂 Models                      # Veritabanı modelleri (Blog, Yorumlar, Iletisim, vb.).
 web.config                  # Veritabanı bağlantı string'i ve Forms Authentication ayarları.
```

---

## Kurulum

1. **Projeyi klonlayın**
   ```bash
   git clone https://github.com/kullanici-adi/TravelTripProje.git
2. Veritabanını oluşturun
- Microsoft SQL Server üzerinde TravelTripDB adında bir veritabanı oluşturun.
- web.config içindeki connection string bölümünü kendi ayarlarınıza göre düzenleyin.
3. Projeyi çalıştırın
- Visual Studio üzerinden projeyi açın.
- IIS Express veya kendi sunucunuz ile çalıştırın.
4. Admin giriş bilgileri
- Varsayılan admin kullanıcı:
  ```bash
  Kullanıcı Adı: admin  
  Şifre: admin
