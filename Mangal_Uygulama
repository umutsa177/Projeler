using System;

namespace Mangal_Uygulama
{
    class Malzemeler
    {
        public string ad_soyad;
        public int işçilik;
        public int boya_ücret;
        public int demir_ücret;
        public int toplam = 0;


        public int Topla(int işçilik_par,int boyaücret_par,int demirücret_par)
        {
            toplam = toplam + işçilik + boya_ücret + demir_ücret;
            Console.WriteLine("ödenmesi gereken tutar={0}",toplam);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cevap;
            Malzemeler asd = new Malzemeler();
            Console.WriteLine("müşterinin adı soyadı nedir?");
            asd.ad_soyad = Console.ReadLine();

            Console.WriteLine("boya ücreti ne kadar?");
            asd.boya_ücret = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("müşterinin adı soyadı nedir?");
            asd.demir_ücret = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hangi boy mangal istersiniz?");
            Console.WriteLine("1-küçük boy 2-orta boy 3-büyük boy");
            cevap = Convert.ToInt32(Console.ReadLine());
            if(cevap==1)
            {
                asd.işçilik = 50;
            }
            else if (cevap == 2)
            {
                asd.işçilik = 75;
            }
            else if (cevap == 3)
            {
                asd.işçilik = 100;
            }
            
            int toplam = asd.Topla(asd.işçilik, asd.boya_ücret,asd.demir_ücret);
            Console.WriteLine("ödenmesi gereken tutar={0}", toplam);
        }
    }
}
