using System;

namespace OOPlab1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();

            dog.Name = "Szarik";

            dog.TakeForWalk(3.0);

            string text = dog.returnSpeciesAndName();
            Console.WriteLine(text);
            text += " afawefawfawe";
            Console.WriteLine(text);

            String nameAndOwner = dog.returnNameAndOwner("Kacper");
            Console.WriteLine(nameAndOwner);

            


            Car Ford = new Car();
            Ford.Make = ("Ford");
            Ford.Model = ("Fiesta");
            Ford.Value = (2000);
            Ford.Color = ("Blue");
            dog.Feed(1.0);
            dog.PrintWeight();

            Human me = new Human();
            me.FirstName = "Kacper";
            me.LastName = "Warda";
            me.Pet = dog;
            me.Salary = 2800;
            me.Automobile = Ford;

            me.Phone = new Phone("onePlus",
                "8Pro",
                2.3,
                "Android");
            Console.WriteLine(me.Phone.Model);

            me.Phone = new Phone("apple", "6s", 5.0, "iOs");

            Console.WriteLine(me.Phone.Model);
            Console.WriteLine(me.Salary);
            
        }
    }
}