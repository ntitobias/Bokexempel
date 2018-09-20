using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokexempel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar ett objekt av klassen Bok
            Bok bok1 = new Bok();

            bok1.titel = "Hackad titel";

            //anropar metoden Skrivut()
            bok1.SkrivUt();

            Console.ReadKey();
        }
    }

    
}
