using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, basamakSayisi = 0, temp;

            sayiGirisi:
            Console.WriteLine("Basamaklarına ayrılacak sayıyı giriniz:");
            string s = Console.ReadLine();

            // string sayi dönüşüm işlemleri için https://youtu.be/IjuDU5AMTOI linkinden ilgili videomu izleyebilirsiniz. 

            if (!Int32.TryParse(s, out sayi) || sayi < 0)
            {
                Console.WriteLine("Girilen değer tam sayı değil veya 0'dan küçük değer girildi");
                goto sayiGirisi;
            }

            temp = sayi;

            while (temp / 10 > 0)
            {
                temp = temp / 10;
                basamakSayisi++;
            }

            basamakSayisi++;
            Console.WriteLine("Basamak sayısı: {0}", basamakSayisi);
            for (int i = basamakSayisi-1; i >= 0; i--)
            {
                int pow = (int) Math.Pow(10, i);
                Console.WriteLine(sayi / pow);
                sayi = sayi % pow;
            }

            Console.ReadLine();
        }
    }
}
