using System;

namespace UserList
{
    public class User
    {
        public int id { get; } = new Random().Next();
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _age;
        private readonly string _place;
        private readonly string _company;

        public User(
            string firstName,
            string lastName,
            string age,
            string place,
            string company
        )
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _place = place;
            _company = company;
        }

        public void PrintMiniInfo()
        {
            Console.WriteLine($"[{_age} years]: {_firstName} {_lastName}\n");
        }
        
        public string PrintDetailInfo()
        {
            return "";
        }
    }
}