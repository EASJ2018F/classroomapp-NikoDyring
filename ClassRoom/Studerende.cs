using System;

namespace ClassRoom
{
    public class Studerende
    {
        public string Name { get; }

        public int BirthMonth { get; }

        public int BirthDay { get; }


        public Studerende()
        {

        }

        public Studerende(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            if (birthMonth > 12 || birthMonth < 1)
            {
                throw new ArgumentException("BirthMonth is invalid.");
            }
            BirthDay = birthDay;
        }
    }



}