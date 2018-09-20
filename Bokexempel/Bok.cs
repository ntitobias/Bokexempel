using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bokexempel
{
    class Bok
    {
        //Deklarationer
        private string titel;
        private string författare;
        private int antalSidor;

        //Konstruktor
        public Bok()
        {
            Console.Write("Ange författare: ");
            this.författare = Console.ReadLine();
            Console.Write("Ange bokens titel: ");
            this.titel = Console.ReadLine();
            Console.Write("Ange antal sidor: ");
            this.antalSidor = Convert.ToInt32(Console.ReadLine());
        }

        //Metod för att skriva ut info om boken
        public void SkrivUt()
        {
            Console.WriteLine("Bokens titel: \t" + titel);
            Console.WriteLine("Författare: \t" + författare);
            Console.WriteLine("Antal sidor: \t" + antalSidor);
        }

        public void ÄndraTitel(string titel)
        {
            this.titel = titel;
        }
    }
}
