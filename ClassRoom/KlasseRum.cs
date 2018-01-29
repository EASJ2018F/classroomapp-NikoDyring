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
    }
}