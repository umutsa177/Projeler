using System;

namespace Atm_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int bakiye, cevap, cevap2, cevap3, cevap4, cevap5, yatırılacak, çekilecek;
                string ad_soyad;
                Console.Write("İsminizi giriniz:");
                ad_soyad = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Bakiyenizi giriniz:");
                bakiye = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("İşlemler");
                Console.WriteLine("1-Bakiye Sorgulama,2-Fatura Ödeme,3-Para Yatırma,4-Para Çekme");
                Console.WriteLine("Hangi işlemi yapmak isterdiniz?");
                cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap == 1)
                {
                    Console.WriteLine("Bakiyeniz:{0}", bakiye);
                }

                else if (cevap == 2)
                {
                    Console.WriteLine("Faturalar");
                    Console.WriteLine("1-Su Faturası,2-Elektrik Faturası,3-Doğalgaz Faturası");
                    Console.WriteLine();
                    Console.WriteLine("Ödemek istediğinizin numarasını giriniz.");
                    cevap2 = Convert.ToInt32(Console.ReadLine());

                    if (cevap2 == 1)
                    {
                        Console.Write("Su faturasını giriniz:");
                        cevap3 = Convert.ToInt32(Console.ReadLine());
                        bakiye = bakiye - cevap3;
                        Console.WriteLine("Ödemeniz başarıyla yapılmıştır.");
                        Console.WriteLine("Kalan bakiyeniz:{0}", bakiye);
                    }
                    else if (cevap2 == 2)
                    {
                        Console.Write("Elektrik faturasını giriniz:");
                        cevap4 = Convert.ToInt32(Console.ReadLine());
                        bakiye = bakiye - cevap4;
                        Console.WriteLine("Ödemeniz başarıyla yapılmıştır.");
                        Console.WriteLine("Kalan bakiyeniz:{0}", bakiye);
                    }
                    else if (cevap2 == 3)
                    {
                        Console.Write("Doğalgaz faturasını giriniz:");
                        cevap5 = Convert.ToInt32(Console.ReadLine());
                        bakiye = bakiye - cevap5;
                        Console.WriteLine("Ödemeniz başarıyla yapılmıştır.");
                        Console.WriteLine("Kalan bakiyeniz:{0}", bakiye);
                    }
                }

                else if (cevap == 3)
                {
                    Console.Write("Yatırmak istediğiniz tutarı giriniz:");
                    yatırılacak = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye + yatırılacak;
                    Console.WriteLine("Yeni bakiyeniz:{0}", bakiye);
                }

                else if (cevap == 4)
                {
                    Console.Write("Çekmek istediğiniz tutarı giriniz:");
                    çekilecek = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye - çekilecek;
                    Console.WriteLine("Yeni bakiyeniz:{0}", bakiye);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar deneyiniz.");
            }
        }
    }
}
