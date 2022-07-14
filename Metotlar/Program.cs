using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Elması";
            product1.Fiyati = 80;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 78;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            // type safe -- tip güvenli "Product" tip belirtiyo.

            foreach (Product product in products)
            {

                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");
            
            }
            Console.WriteLine("-----------METOTLARR--------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);


            
        }



        }
    }




//  Do not repeat yourself