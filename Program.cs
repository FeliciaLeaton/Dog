using System;

namespace Dog
{
    public enum gender {Male, Female};
    public class Dog 
    {
        public string Name;
        public string Owner;
        public int Age;
        public gender Gender;

        public Dog(string Name,string Owner, int Age, gender Gender)
        {
            this.Name=Name;
            this.Owner= Owner;
            this.Age=Age;
            this.Gender=Gender;
        }

        public void Bark(int barks)
        {
            for (int i = 0; i < barks; i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        public string GetTag()
        {
            string tag ="If lost, call "+ Owner+ ".";
            if (Gender==0)
            {
                tag+="His name is "+ Name + "he is " + Age.ToString();
            }
            else
            {
                tag+="Her name is " + Name + "she is " + Age.ToString();
            }

            if (Age>1)
            {
                tag+= " years old.";
            }
            else
            {
                tag+= " year old.";
            }
            return tag;



        }








    }
    class Program
    {
        static void Main(string[] args)
        {
          Dog puppy = new Dog("Orion", "Shawn", 1, gender.Male);  // create object instance
puppy.Bark(3); // output: Woof!Woof!Woof!
Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

Dog myDog = new Dog("Lileu", "Dale", 4, gender.Female);  // create object instance
myDog.Bark(1); // output: Woof!
Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
    }
}
