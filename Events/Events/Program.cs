using System;

namespace Events
{
    public delegate void myDelegate(string name);
    class Program
    {
        public event myDelegate myEvent;

        public Program()
        {
            myEvent += new myDelegate(SayHiEnglish);
            myEvent += new myDelegate(SayHiArabic);
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.myEvent("Alejandro");
            World info = new World();
            info.DisplayCitizenInformation("Swede", "Sweden");
            info.DisplayState("Alberta", "Canada");
        }

    public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi"+name);
        }
    public void SayHiArabic(string name)
        {
            Console.WriteLine("Marhaaban " + name);
        }
    }

    class World
    {
        private DisplayInformation displayInformationInstance;

        public World()
        {
            displayInformationInstance = new DisplayInformation();
            displayInformationInstance.DisplayDateAfterEvent += DisplayInfoInstance_DisplayDateAfterEvent; 
        }

        private void DisplayInfoInstance_DisplayDateAfterEvent()
        {
            Console.WriteLine("Information has been displayed on "+ DateTime.Now.ToShortTimeString());
        }

        public void DisplayState(string stateName, string country)
        {
            displayInformationInstance.DisplayState(stateName, country);
        }

        public void DisplayCitizenInformation(string citizen, string state)
        {
            displayInformationInstance.DisplayCitizen(citizen, state);
        }
    }

    class DisplayInformation
    {
        public delegate void DisplayDateAfterDelegate();

        public event DisplayDateAfterDelegate DisplayDateAfterEvent;

        public void DisplayState(string stateName, string country)
        {
            Console.WriteLine($"{stateName} is located in {country}");
            DisplayDateAfterEvent();
            Console.WriteLine();
        }

        public void DisplayCitizen(string person, string state)
        {
            Console.WriteLine($"{person} lives in {state}");
        }
    }
}
