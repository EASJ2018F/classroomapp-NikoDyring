using System;

namespace ClassRoom
{
    public class Studerende
    {
        public string Name { get; }

        public int BirthMonth { get; }

        public int BirthDay { get; }
        public string BirthSeason { get; set; }


        public Studerende()
        {

        }

        public Studerende(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public string FindBirthSeason()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                BirthSeason = "Vinter";
                return BirthSeason;
            }
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                BirthSeason = "Forår";
                return BirthSeason;
            }
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                BirthSeason = "Sommer";
                return BirthSeason;
            }
            else if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
                BirthSeason = "Efterår";
                return BirthSeason;
            }

            switch (BirthMonth)
            {
                case 1:
                    BirthSeason = "Vinter";
                    break;
                case 2:
                    BirthSeason = "Vinter";
                    break;
                case 3:
                    BirthSeason = "Forår";
                    break;
                case 4:
                    BirthSeason = "Forår";
                    break;
                case 5:
                    BirthSeason = "Forår";
                    break;
                case 6:
                    BirthSeason = "Sommer";
                    break;
                case 7:
                    BirthSeason = "Sommer";
                    break;
                case 8:
                    BirthSeason = "Sommer";
                    break;
                case 9:
                    BirthSeason = "Efterår";
                    break;
                case 10:
                    BirthSeason = "Efterår";
                    break;
                case 11:
                    BirthSeason = "Efterår";
                    break;
                case 12:
                    BirthSeason = "Vinter";
                    break;
                default:
                    return BirthSeason;
            }

            return BirthSeason;
        }
    }



}