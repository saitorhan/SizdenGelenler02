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

            if (!Int32.TryParse(s, out sayi) || sayi < 0 || sayi > Int32.MaxValue -1)
            {
                Console.WriteLine("Girilen değer tam sayı değil veya sayı izin verilen aralık (0 - {0}) dışında girildi.", Int32.MaxValue);
                goto sayiGirisi;
            }

            temp = sayi;

            while (temp / 10 > 0)
            {
                temp = temp / 10;
                basamakSayisi++;
            }

            basamakSayisi++;
            Console.WriteLine("Girilen Sayının Basamak sayısı: {0}", basamakSayisi);
            Console.WriteLine("Sayının Basamakları:");
            string basamakAd;

            for (int i = basamakSayisi-1; i >= 0; i--)
            {
                int pow = (int) Math.Pow(10, i);

                switch (i)
                {
                    case 9:
                        basamakAd = "Milyarlık";
                        break;
                    case 8:
                        basamakAd = "Yüz Milyonluk";
                        break;
                    case 7:
                        basamakAd = "On Milyonluk";
                        break;
                    case 6:
                        basamakAd = "Milyonluk";
                        break;
                    case 5:
                        basamakAd = "Yüz Binlik";
                        break;
                    case 4:
                        basamakAd = "On Binlik";
                        break;
                    case 3:
                        basamakAd = "Binlik";
                        break;
                    case 2:
                        basamakAd = "Yüzlük";
                        break;
                    case 1:
                        basamakAd = "Onluk";
                        break;
                    case 0:
                        basamakAd = "Birlik";
                        break;
                    default:
                        basamakAd = String.Empty;
                        break;
                }

                Console.WriteLine("{0} tane {1}", sayi / pow, basamakAd);
                sayi = sayi % pow;
            }

            Console.ReadLine();
        }
    }
}
