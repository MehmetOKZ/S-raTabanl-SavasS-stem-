# 🎮 Sıra Tabanlı Savaş Sistemi (C# Konsol Uygulaması)

Bu proje, temel C# bilgilerini kullanarak geliştirilmiş basit bir sıra tabanlı savaş sistemidir. Oyuncu ve düşman sırayla saldırır veya iyileşir. Oyunun amacı hayatta kalan taraf olmaktır!

---

## 🧪 Özellikler

- Oyuncu ve düşmanın sağlık puanları vardır.
- Oyuncu kendi turunda saldırabilir veya iyileşebilir.
- Düşman, rastgele saldırır veya iyileşir.
- Oyun, biri 0 cana ulaşana kadar devam eder.
- Kazanan sonunda ekrana yazdırılır.

---

## 🚀 Başlatmak için

### Gereksinimler

- .NET SDK (örn: .NET 6.0 veya üzeri)
- Bir C# IDE'si (Visual Studio, Rider veya VS Code + C# uzantısı)

### Projeyi Çalıştır

1. Projeyi indir veya klonla:
   ```bash
   git clone https://github.com/MehmetOKZ/S-raTabanl-SavasS-stem-.git
  
1. 🧠 Nasıl Oynanır?
Oyun başladığında, oyuncuya bir seçenek sunulur:

a tuşuna basarak saldırabilirsin.

h tuşuna basarak kendini iyileştirebilirsin.

Her turdan sonra düşman da rastgele bir hareket yapar: ya saldırır ya da kendini iyileştirir.

Amaç, düşmanı yenip hayatta kalan taraf olmaktır.

📸 Ekran Görüntüleri
Aşağıda oyunun çalışma anından bazı ekran görüntüleri yer almaktadır:

Oyunun Başlangıcı
https://github.com/MehmetOKZ/S-raTabanl-SavasS-stem-/blob/master/asset/Screenshot-1.png?raw=true

Oyuncu Saldırdıktan Sonra
https://github.com/MehmetOKZ/S-raTabanl-SavasS-stem-/blob/master/asset/Screenshot-2.png?raw=true

Düşman İyileştiğinde
https://github.com/MehmetOKZ/S-raTabanl-SavasS-stem-/blob/master/asset/Screenshot-3.png?raw=true

Oyunun Sonu (Kazandınız)
https://github.com/MehmetOKZ/S-raTabanl-SavasS-stem-/blob/master/asset/Screenshot-4.png?raw=true

👨‍💻 Koddan Bir Kesit
csharp
Kopyala
Düzenle
if (secenek == "a")
{
    DüşmanHp -= oyuncuSaldırı;
    Console.WriteLine("Oyuncu saldırdı düşman hasar aldı " + oyuncuSaldırı + " hasar!");
}
else
{
    oyuncuHp += iyileşmeMiktarı;
    Console.WriteLine("Oyuncu iyileşti " + iyileşmeMiktarı + " sağlık puanları!");
}
Bu bölümde oyuncu bir seçim yapar: saldırı veya iyileşme.

✨ Geliştirme Önerileri
Daha fazla düşman tipi

Zorluk seviyesi

Oyuncu için özel yetenekler

Grafik arayüz (örneğin: Windows Forms ya da Unity)

👤 Geliştirici
Mehmet OKZ

Bu proje, C# öğrenme sürecinin bir parçası olarak oluşturulmuştur. Eğlenerek öğrenmeye devam et!

