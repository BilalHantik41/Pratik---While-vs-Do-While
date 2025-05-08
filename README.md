WhileDoWhile

Bu proje, C# konsol uygulaması içerisinde while ve do-while döngülerinin temel kullanım farklarını örneklerle göstermektedir. Uygulamayı çalıştırarak, her iki döngü türünün çalışma mantığını ve davranış farklarını görebilirsiniz.

Proje İçeriği

Program.cs:

1. Soru (While Döngüsü): Yorum satırı olarak eklenmiştir. Sayac değişkeni 0’dan başlayarak Limit değerine kadar döner ve her adımda konsola "Ben bir Patika’liyim" ifadesini yazar.

2. Soru (Do-While Döngüsü): Aktif olarak çalışmaktadır. Sayac değişkeni 1’den başlayarak Limit değerine kadar döner ve her adımda konsola "Ben bir Patika’liyim" ifadesini yazar. do-while bloğu en az bir kez çalışacaktır.

Gereksinimler

.NET SDK (tercihen .NET 6.0 veya üzeri)

C# derleyici (örneğin dotnet CLI)

Kurulum ve Çalıştırma

Depoyu klonlayın veya dosyaları indirin:

git clone https://github.com/kullanici/WhileDoWhile.git
cd WhileDoWhile

Program.cs içindeki yorum satırlarını kaldırarak önce while örneğini, ardından do-while örneğini ayrı ayrı çalıştırabilirsiniz.

While Döngüsü çalıştırmak için:

Do-While bloğunu yorum satırı (/* ... */) içine alın.

While bloğunu yorumdan çıkarın.

dotnet run komutu ile çalıştırın.

Do-While Döngüsü çalıştırmak için:

While bloğunu yorum satırına alın.

Do-While bloğunu yorumdan çıkarın.

dotnet run komutu ile çalıştırın.

Projeyi derleyip çalıştırın:

dotnet build
dotnet run --project WhileDoWhile

Açıklamalar

While Döngüsü: Koşul başta kontrol edilir. Koşul sağlanıyorsa kod bloğu çalışır; değilse hiç çalışmaz.

Do-While Döngüsü: Kod bloğu önce en az bir kez çalışır, ardından koşul kontrol edilir. Koşul sağlanıyorsa tekrar eder.

// While döngüsünde Limit 0 yapılsa bile hiç çalışmaz.
while (Sayac <= Limit)
{
    // ...
}

// Do-while bloğu en az bir kez çalışmak zorundadır.
do
{
    // ...
}
while (Sayac <= Limit);

