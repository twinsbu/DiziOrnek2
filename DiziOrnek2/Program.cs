using System;

namespace DiziOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Bir boyutlu dizi oluşturma
            int[] sayilar = new int[5];  // 5 elemanlı bir dizi oluşturuyoruz

            // 2. Diziye değer aktarma
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 50;

            // 3. Dizi elemanlarına erişim
            Console.WriteLine("Dizinin elemanları:");
            for (int i = 0; i < sayilar.Length; i++)  // Dizinin tüm elemanlarını yazdırıyoruz
            {
                Console.WriteLine("sayilar[" + i + "] = " + sayilar[i]);
               
            } 

            // Alternatif: Dizi elemanlarını tek tek yazdırma
            /*
            Console.WriteLine(sayilar[0]);  // 10
            Console.WriteLine(sayilar[1]);  // 20
            Console.WriteLine(sayilar[2]);  // 30
            Console.WriteLine(sayilar[3]);  // 40
            Console.WriteLine(sayilar[4]);  // 50
            */

            Console.ReadLine();  // Programın çıktısını görmek için
        }
    }
}
