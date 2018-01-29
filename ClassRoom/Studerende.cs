namespace ClassRoom
{
    public class Studerende
    {
        private string _name;
        private int _birthMonth;
        private int _birthDay;

        public string Name => _name;
        public int BirthMonth => _birthMonth;
        public int BirthDay => _birthDay;


        public Studerende(string name, int birthMonth, int birthDay)
        {
            name = Name;
            birthMonth = BirthMonth;
            birthDay = BirthDay;
        }




    }



}