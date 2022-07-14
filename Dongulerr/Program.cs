using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dongulerr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // array - dizi

            string[] kurslar = new string[] { "Yazılım geliştirici" , 
                "Programlamaya Başlangıç", 
                "Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti.");

            foreach (string kurs in kurslar) // dizilerin içinde dolaşır
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
