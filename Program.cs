using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string [] args)
        {/*
            Console.WriteLine("1. Soru: While Döngüsü");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Lütfen Bir Limit Belirleyiniz:");
            Console.WriteLine("---------------------------------------------");
           int Sayac = 0;
           int Limit = int.Parse(Console.ReadLine());  // Burdaki Değer Kadar dönmeden sistem kendini tamamlamıcak.
            while (Sayac <= Limit )
            {   Console.WriteLine("---------------------------------------------");
                Console.WriteLine(Sayac +" kez"+" "+"Ben bir Patika'liyim");
                Sayac++;
            }
            Console.WriteLine("---------------------------------------------");

            */

            Console.WriteLine("2. Soru: Do While Döngüsü");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Lütfen Bir Limit Belirleyiniz:");
            Console.WriteLine("---------------------------------------------");
            int Sayac = 1;
            int Limit = int.Parse(Console.ReadLine()); // Burayi 0 yapsan bile Konsola 1 kez Ben bir patikaliyim yazicak ve döngüyü bitiricek
            do
            {  Console.WriteLine("---------------------------------------------");
               Console.WriteLine(Sayac +" kez"+" "+"Ben bir Patika'liyim");
                Sayac++;
            } 
            
            while (Sayac <= Limit);
            {   
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Döngü Bitti ve İşlem Sonlandi...");
            }
            Console.WriteLine("---------------------------------------------");
        }    // Yorum Satirlarini kaldirarak While Döngüsünü ayri Do While Döngüsünü ayri çalıştırmalisiniz. 
             //İkisi aynanda çalışırsa 100 kez While döngüsünde yazar 1 kezde Do While döngüsünde 101 kez yazmış olur

             // Do While Şeklinde bir kod bloğu en az 1 kez çalışmak zorundadir. Limit 0 yapılsa bile 1 kez çalıştiktan sonra sonlanir.
             // While döngüsünde limit kadar çalışmadan sistem durmaz.
    }
}