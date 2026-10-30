# ASP.NET Core MVC - Tutorial

ASP.NET Core MVC yapısını öğrenmek ve temel kavramları uygulamalı olarak pekiştirmek amacıyla geliştirdiğim örnek projedir.

Proje; MVC mimarisi, Controller-View ilişkisi, Razor syntax, model kullanımı ve yeniden kullanılabilir View bileşenleri üzerine basit örnekler ve kod içi açıklamalar içerir.

## Kullanılan Teknolojiler

- .NET 10 / ASP.NET Core MVC
- C#
- Razor View Engine
- HTML / CSS
- Bootstrap 5

## Proje İçeriği

Bu repoda aşağıdaki konulara ilişkin örnekler bulunmaktadır:

- **MVC mimarisi:** Model, View ve Controller yapılarının kullanımı.
- **Routing:** Controller, Action ve route parametreleriyle sayfa yönlendirme.
- **Model Binding / View'a veri aktarımı:** Controller'dan View'a model nesneleri ve listeler gönderme.
- **Razor Syntax:** `@model`, `@Model`, `@foreach`, `@if` gibi ifadeler.
- **Layout kullanımı:** `_Layout`, `_LayoutAdmin`, `_ViewStart` ve `RenderBody()` yapıları.
- **Partial Views:** `Html.PartialAsync()` ile ortak bileşenlerin kullanılması ve bu bileşenlere model aktarımı.
- **Tag Helpers:** `asp-controller`, `asp-action`, `asp-route-id` kullanımı.
- **Static Files:** `wwwroot` üzerinden CSS ve görsel dosyalarına erişim.

## Örnek Sayfalar

Proje içerisinde üç temel Controller bulunmaktadır:

| Controller | Açıklama |
|---|---|
| HomeController | Temel sayfa yönlendirmeleri ve farklı Layout kullanımı |
| CourseController | Kurs listeleme, detay gösterimi, model aktarımı ve Partial View örnekleri |
| ProductsController | Ürün listeleme ve ürün detaylarının model üzerinden gösterimi |

Örnek veriler şimdilik Controller içerisinde tanımlanan nesneler ve listeler üzerinden kullanılmaktadır. Herhangi bir veritabanı entegrasyonu bulunmamaktadır.

## Proje Yapısı

- `Controllers/` - HTTP isteklerini karşılayan Controller sınıfları
- `Models/` - Course ve Product gibi veri modelleri
- `Views/` - Razor sayfaları, Layout ve Partial View dosyaları
- `wwwroot/` - Statik dosyalar (CSS, görseller vb.)
- `Program.cs` - Uygulama yapılandırması ve routing
- `appsettings.json` - Uygulama ayarları

## Kurulum ve Çalıştırma

Projeyi çalıştırmak için **.NET 10 SDK** kurulu olmalıdır.

**1. Repoyu klonlayın:**

```bash
git clone https://github.com/abdullahTaha050/dotnet_mvc_tutorial.git
cd dotnet_mvc_tutorial
```

**2. Bağımlılıkları yükleyin:**

```bash
dotnet restore
```

**3. Uygulamayı başlatın:**

```bash
dotnet run
```

Uygulama başlatıldıktan sonra terminalde belirtilen localhost adresinden erişilebilir.

## Not

Bu proje öğrenme ve pratik yapma amacıyla geliştirilmektedir. İçerisindeki kodlar, MVC kavramlarını basit örneklerle göstermek amacıyla yazılmıştır. Proje ilerleyen süreçte yeni örnekler ve konularla genişletilebilir.

---

**Geliştirici:** [Abdullah Taha Aksakal](https://github.com/abdullahTaha050)
