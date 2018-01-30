using System;
using System.Collections.Generic;

namespace ClassRoom
{
    public class KlasseRum
    {
        private string _className;
        private List<Studerende> _klasseListe;
        private DateTime _semesterStart;

        public string KlasseNavn
        {
            get
            {
                return _className;
            }
            set
            {
                _className = value;
            }
        }

        public List<Studerende> KlasseListe
        {
            get
            {
                return _klasseListe;
            }
            set
            {
                _klasseListe = value;
            }
        }

        public DateTime SemesterStart
        {
            get
            {
                return _semesterStart;
            }
            set
            {
                _semesterStart = value;
            }
        }

        public KlasseRum(string klasseNavn, List<Studerende> list, DateTime semesterStart)
        {
            KlasseNavn = klasseNavn;
            KlasseListe = list;
            SemesterStart = semesterStart;
        }

        public string FindBirthSeason(int BirthMonth)
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                return "Vinter";
            }
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Forår";
            }
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Sommer";
            }
            else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                return "Efterår";
            }
            return "Out of index";
        }
    }
}