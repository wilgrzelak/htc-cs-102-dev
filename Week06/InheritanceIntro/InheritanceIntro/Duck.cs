using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
   public class Duck
    {
        public class Dog
        {

            public string Breed;

            public void Bark()
            {
                MessageBox.Show("Bark");
            }

            public void SayName()
            {
                MessageBox.Show("My name is " + this.Name);
            }

            public Dog() { }

            public Dog(string breed, int height, string name)
            {
                this.Breed = breed;
                this.Height = height;
                this.Name = name;
            }
        }
    }
}
