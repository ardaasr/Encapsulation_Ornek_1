using System.Drawing;

namespace Encapsulation_Ornek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir Üniversite öğrencisinin vize ve final notları alınacaktır. Alınan notların 0-100 aralığı encapsulation ile kontrol edilecektir. Doğru girilene kadar notlar istenecektir.Doğru girilen not bir daha istenmeyecektir.İki notunda doğru girilmesi durumunda OrtalamaHesapla() metodu ile vizenin %40 final%60 alınarak ortalama öğrenciye gösterilecek.

            Ogrenci ogrenci = new Ogrenci();

            
            while (ogrenci._vize == 0)
            {
                Console.WriteLine("Vize:");
                try
                {
                    ogrenci._vize = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş! Lütfen bir sayı giriniz.");
                }
            }

            
            while (ogrenci._final == 0)
            {
                Console.WriteLine("Final:");
                try
                {
                    ogrenci._final = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş! Lütfen bir sayı giriniz.");
                }
            }

            
            Console.WriteLine($"Öğrencinin ortalaması: {ogrenci.ortalama:F2}"); //F2 formatı, bir sayıyı ondalık formatta ve virgülden sonra 2 basamak göstererek yazdırmak için kullanılır.
            // F sayısı ondalık formata çevirir.
            // 2 de virgülden sonra 2 basamak gösterilceğini belirtir.


        }
    }

    class Customer
    {
       
        public string Name;
        public string Surname;
        private long TC;  

        public long _TC
        {
            
            get // değişkenin değerini okur.
            { return TC; }

            set // değişkenin değerini atar.
            {
                if (value.ToString().Length == 11) // tc 11 basamak mı kontrol eder 11 basamaksa bu çalışır
                {
                    TC = value;
                } 
                else // 11 basamak değilse tc değeri 0 verilir
                {
                    TC = 0;
                }
            }
        }
    }

    class Ogrenci
    {
        private int final;
        private int vize;

        public double ortalama
        {
            get { return vize * 0.4 + final * 0.6; }
        }

        public int _vize
        {
            get { return vize; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    vize = value;
                }
                else
                {
                    Console.WriteLine("Vize Notunuz HATALI!!! 0 ile 100 arasında olmalıdır.");
                    vize = 0;
                }
            }
        }

        public int _final
        {
            get { return final; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    final = value;
                }
                else
                {
                    Console.WriteLine("Final Notunuz HATALI!!! 0 ile 100 arasında olmalıdır.");
                    final = 0;
                }
            }
        }
    }
}