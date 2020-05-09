using System;

namespace _2_OOP
{
    class Program
    {
        static string name = "Robert"; // this global variable can be used in other methods with the static keyword
        static void Main(string[] args)
        {

            Person personOne = new Person();
            personOne.FirstName = "Alejandro";
            personOne.LastName = "Ramos";
            personOne.BirthDate = Convert.ToDateTime("1990-04-07");
            personOne.Country = "Mexico";
            
            DateTime date = new DateTime();

            SayHi(); // static methods do not need a reference value to be initialized

            personOne.SayHi(); // non static methods need to be initialized

        }
        static void SayHi()
        {
            name = "Roberto";
            Console.WriteLine($"Hi {name} from the static method!");
        }
    }

    class Person
    {
        public Person()
        {
            firstName = "Not provided";
            lastName  = "Not provided";
            birthDate = Convert.ToDateTime("1900-01-01");
            Country = "Not provided";
        }
        string firstName; // variables of classes are hidden by default 
        string lastName;
        DateTime birthDate;
        string country;

        private string privateVariable;
        public string publicVariable;
        protected string protectedVariable;
        internal string internalVariable;

        private void MeditatePrivate()
        {

        }

        public void MeditatePublic()
        {

        }

        protected void MeditateProtected()
        {

        }

        internal void MeditateInternal()
        {

        }

        public string FirstName // property names are Pascal Case
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate { get; set; }
        public string Country { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Hello from the non static method.");
        }
    }

    class OldPerson: Person
    {
        Person person = new Person();

        void TakePills()
        {

        }
    }

    class YoungPerson
    {
        Person person = new Person();
    }
}
