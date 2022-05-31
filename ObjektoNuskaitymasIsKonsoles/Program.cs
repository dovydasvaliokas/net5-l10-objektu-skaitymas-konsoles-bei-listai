using System;

namespace ObjektoNuskaitymasIsKonsoles // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vienos prekės nuskaitymass
      /*      Preke preke1;

            preke1 = NuskaitytiPreke();
            IsvestiPreke(preke1);*/



            // Kelių prekių nuskaitymass
            List<Preke> prekeList = new List<Preke>();

            prekeList = NuskaitytiKeliasPrekes();
            Console.WriteLine("----------------");
            IsvestiKeliasPrekes(prekeList);



            
        }


        static Preke NuskaitytiPreke()
        {
            Preke preke = new Preke();

            Console.WriteLine("Įveskite prekės pavadinimą: ");
            string pavadinimas = Console.ReadLine();
            preke.Pavadinimas = pavadinimas;

            Console.WriteLine("Įveskite prekės aprašymą: ");
            string aprasymas = Console.ReadLine();
            preke.Aprasymas = aprasymas;

            Console.WriteLine("Įveskite prekės kainą: ");
            double kaina = Convert.ToDouble(Console.ReadLine());
            preke.Kaina = kaina;

            Console.WriteLine("Įveskite prekės id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            preke.Id = id;

            return preke;
        }


        static List<Preke> NuskaitytiKeliasPrekes()
        {
            List<Preke> prekeList = new List<Preke>();
            int n;

            Console.WriteLine("Įveskite kiek bus prekių: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                prekeList.Add(NuskaitytiPreke());
            }
            return prekeList;
        }


        static void IsvestiPreke(Preke preke)
        {
            Console.WriteLine("Pavadinimas: " + preke.Pavadinimas);
            Console.WriteLine("Aprašymas: " + preke.Aprasymas);
            Console.WriteLine("Kaina: " + preke.Kaina);
            Console.WriteLine("Id: " + preke.Id);
        }


        static void IsvestiKeliasPrekes(List<Preke> prekeList)
        {
            foreach (Preke preke in prekeList)
            {
                IsvestiPreke(preke);
                Console.WriteLine("---------------");
            }
        }
    }
}