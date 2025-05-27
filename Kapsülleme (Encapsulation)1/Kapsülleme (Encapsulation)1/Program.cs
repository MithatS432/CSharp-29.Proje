using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme__Encapsulation_1
{
    internal class Program
    {
        class Ogrenci
        {
            // Alanlar (fields) gizli (private)
            private string isim;
            private int not;

            // Özellik (property) üzerinden kontrollü erişim
            public string Isim
            {
                get { return isim; }
                set { isim = value; }
            }

            public int Not
            {
                get { return not; }
                set
                {
                    if (value >= 0 && value <= 100)
                        not = value;
                    else
                        Console.WriteLine("Not 0 ile 100 arasında olmalıdır.");
                }
            }

            public void BilgiYazdir()
            {
                Console.WriteLine($"Öğrenci: {isim}, Notu: {not}");
            }
        }
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Isim = "Ayşe";
            ogr.Not = 95;

            ogr.BilgiYazdir();

            ogr.Not = 150; // Hatalı not girilirse uyarı verir
        }
    }
}
