using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıraTabanlıSavasSıstemı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int oyuncuHp = 40;
            int DüşmanHp = 20;

            int iyileşmeMiktarı = 5;

            Random rastgele =new Random();


            int oyuncuSaldırı = 5;
            int düşmanSaldırı = 7;

            while (oyuncuHp > 0 && DüşmanHp > 0)
            {

                //Oyuncu Turu
                Console.WriteLine("-- Oyuncunun Sırası --");
                Console.WriteLine("Oyuncu Hp - " + oyuncuHp + ". Düşman Hp -" +DüşmanHp);
                Console.WriteLine("Saldırmak için 'a' veya can doldurmak için 'h' basınız.");

                string secenek = Console.ReadLine();

                if (secenek == "a")
                {
                    DüşmanHp -= oyuncuSaldırı;
                    Console.WriteLine("Oyuncu saldırdı düşman hasar aldı " + oyuncuSaldırı + " hasar!");
                }
                else
                {
                    oyuncuHp += iyileşmeMiktarı;
                    Console.WriteLine("Oyuncu iyileşti " + iyileşmeMiktarı + " sağlık puanları! ");
                }
                // Düşman turu
                if (DüşmanHp > 0)
                {
                    Console.WriteLine("-- Düşmanın Sırası --");
                    Console.WriteLine("Oyuncu Hp - " + oyuncuHp + ". Düşman Hp -" + DüşmanHp);
                    int düşmansecenek= rastgele.Next(0,2);
                    if (düşmansecenek == 0)
                    {
                        oyuncuHp -= düşmanSaldırı;
                        Console.WriteLine("Düşman saldırdı oyuncu hasar aldı " + düşmanSaldırı + "hasar !");

                    }
                    else
                    {
                        DüşmanHp += iyileşmeMiktarı;
                        Console.WriteLine("Düşman iyileşti " + iyileşmeMiktarı + "sağlık puanları!");
                    }
                }

            }
            if (oyuncuHp > 0)
            {
                Console.WriteLine("Tebrikler, kazandınız!");
            }
            else
            {
                Console.WriteLine("Kaybettiniz!");
            }
        }
    }
}
