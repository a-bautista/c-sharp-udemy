using System;
using System.Reflection;

namespace CustomAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Animal);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }

    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class Developer : System.Attribute
    {
        private bool isReviewed;
        private string message;
        private string developerName;

        public bool IsReviewed
        {
            get { return isReviewed; }
            set { isReviewed = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string DeveloperName
        {
            get { return developerName; }
            set { developerName = value; }
        }

        public Developer(string developerName, bool isReviewed, string message)
        {
            this.developerName = developerName;
            this.isReviewed = isReviewed;
            this.message = message;
        }
    }
    [Developer("Alejandro Ramos", false, "This needs to be completed next week!")]
    [Obsolete]
    class Animal
    {

    }
}
