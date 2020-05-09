using System;
using WorldNamespace;

namespace _7_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Country countryOne = new Country();
            Country countryTwo = new Country();
            
            CountryLanguage countryLanguageStruct = new CountryLanguage();

            // Assign the struct to the Enum values
            countryLanguageStruct.FirstLanguage = Language.Spanish.ToString();
            countryLanguageStruct.SecondLanguage = Language.English.ToString();

            countryOne.PlanetName = "Earth";
            countryOne.Continent = Continent.America;
            countryOne.CountryName = "Mexico";
            countryOne.Capital = "Mexico City";
            countryOne.Currency = Currency.MXN; // Assign Currency value to Currency value
            countryOne.CountryLanguage =  countryLanguageStruct;

            countryOne.SayHi(countryOne.CountryName);

            countryTwo.PlanetName = "Earth";
            countryTwo.Continent = Continent.Europe;
            countryTwo.CountryName = "United Kingdom";
            countryTwo.Capital = "London";
            countryTwo.Currency = Currency.LB; // Assign Currency value to Currency value
            countryTwo.CountryLanguage = countryLanguageStruct;

            countryTwo.SayHi(countryTwo.CountryName);
            

        }
    }
  
}

namespace WorldNamespace
{
    /// <summary>
    /// Class World is the base class for the child class Country. 
    /// </summary>
    abstract class World
    {
        private string planetName;
        private Continent continent;
        /// <summary>
        /// PlanetName provides the encapsulation methods. 
        /// </summary>
        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continent Continent
        {
            get { return continent; }
            set { continent = value; }
        }
    }
    /// <summary>
    /// Class Country will be used for storing the details of any country. 
    /// </summary>
    class Country : World
    {
        private string countryName;
        private string capital;
        private Currency currency;
        private CountryLanguage countryLanguage;

        #region Properties of the class Country
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }


        public Currency Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public CountryLanguage CountryLanguage
        {
            get { return countryLanguage; }
            set { countryLanguage = value; }
        }

        #endregion

        public Country()
        {
            countryName = "Unknown";
            capital = "Unknown";
        }


        #region Methods of the class Country
        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
        /// <summary>
        /// Overloaded method to display the name of the country.
        /// </summary>
        /// <param name="country">string used to hold the country name</param>
        public void SayHi(string country)
        {
            Console.WriteLine($"Hi {country}");
        }

        #endregion
    }

    struct CountryLanguage
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }

    enum Continent {
         Africa,
         Europe,
         America,
         Asia,
         Australia,
         Antarctica
    }

    enum Currency
    {
        USD,
        Yuan,
        Euro,
        MXN,
        LB

    }

    enum Language
    {
        English,
        Mandarin,
        Spanish,
        German
    }

}