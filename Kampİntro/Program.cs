using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass{
    public static void Main(string[] args)
    {
        //type safety - tip güvenliği
        string kategorietiketi = "Kategoriler";
        int ogrencisayisi = 32000;
        double faizOranı = 1.45;
        bool sistemeGirisYapilmisMi = false; //normalde "false" bir veri kanağından gelecek.
        double dolarDun = 7.45;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış Butonu Göster");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Butonu Göster");
        }
        else
        {
            Console.WriteLine("Değişmedi");
        }
        
        if (sistemeGirisYapilmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else 
        {
            Console.WriteLine("Giriş yap butonu");
        }

        Console.WriteLine(kategorietiketi);

        
    }

}

