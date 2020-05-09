using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        private string personalName;
        private int age;

        #region attributes
        public string PersonalName
        {
            get => personalName;
            set => personalName = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        #endregion

        #region methods
        public void Eat() {}
        public void Sleep() {}
        public void Spawn() {}
        public void Rest() {}
        public void Play() {}
        #endregion

    }
}
