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
            List<Studerende> klasseListe = new List<Studerende> { new Studerende("Peter", 12, 24), new Studerende("Casper", 4, 22), new Studerende("Carl Ejner", 5, 26), new Studerende("Karlo", 8, 19), new Studerende("Nikolaj", 9, 24), new Studerende("Chris", 10, 7) };
            DateTime semesterStart = new DateTime(2017, 12, 28, 8, 10, 0);
            KlasseRum klasse = new KlasseRum("3A", klasseListe, semesterStart);


            Console.WriteLine(klasse.KlasseNavn);
            foreach (Studerende person in klasseListe)
            {
                Console.WriteLine("Studerendes Navn: " + person.Name);
                klasse.FindBirthSeason(person.BirthMonth);
            }

            Console.WriteLine("Semester start er: " + klasse.SemesterStart);

            var winterStudents =
                (from student in klasseListe
                 where klasse.FindBirthSeason(student.BirthMonth) == "Vinter"
                 select student.Name).Count();

            var springStudents =
                (from student in klasseListe
                 where klasse.FindBirthSeason(student.BirthMonth) == "Forår"
                 select student.Name).Count();

            var summerStudents =
                (from student in klasseListe
                 where klasse.FindBirthSeason(student.BirthMonth) == "Sommer"
                 select student.Name).Count();

            var autumnStudents =
                (from student in klasseListe
                 where klasse.FindBirthSeason(student.BirthMonth) == "Efterår"
                 select student.Name).Count();

            Console.WriteLine();
            Console.WriteLine("Studerende med fødselsdag i Forår: " + springStudents);
            Console.WriteLine("Studerende med fødselsdag i Sommer: " + summerStudents);
            Console.WriteLine("Studerende med fødselsdag i Efterår: " + autumnStudents);
            Console.WriteLine("Studerende med fødselsdag i Vinter: " + winterStudents);


            Console.ReadLine();

        }
    }
}
