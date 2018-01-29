using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studerende> liste = new List<Studerende> { new Studerende("Peter", 12, 24), new Studerende("Casper", 4, 22), new Studerende("Carl Ejner", 5, 26) };
            DateTime semesterStart = new DateTime(2017, 8, 28, 8, 10, 0);
            KlasseRum klasse = new KlasseRum("3A", liste, semesterStart);


            Console.WriteLine(klasse.KlasseNavn);
            foreach (Studerende person in liste)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.FindBirthSeason());

            }

            Console.WriteLine(klasse.SemesterStart);

            

            Console.ReadLine();

        }
    }
}
