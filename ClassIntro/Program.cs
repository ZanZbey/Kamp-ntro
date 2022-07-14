using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adı = "Aliozan";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.İzlenmeOranı = 65;
            kurs1.Egitmen = "Engin Demiroğ";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.İzlenmeOranı = 49;
            kurs2.Egitmen = "Kerem Yargın";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.İzlenmeOranı = 48;
            kurs3.Egitmen = "Mustafa Ali";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.İzlenmeOranı = 100;
            kurs4.Egitmen = "Murat Kurtboğan";


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

             
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int  İzlenmeOranı { get; set; }
    }
}
