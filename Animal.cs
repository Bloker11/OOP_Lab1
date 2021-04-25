
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    public class Animal
    {
        public readonly string Species = "canis";
        public string Name;
        private double weight;

        public Animal()
        {
            weight = 3.0;
        }

        public void PrintWeight()
        {
            Console.WriteLine(weight);
        }

        public void Feed(double foodWeight)
        {
            if (weight > 0)
            {
                weight += foodWeight;
                Console.WriteLine("thx for food, bro");
                Console.WriteLine("my weight is now " + weight);
            }
            if (weight <= 0)
            {
                Console.WriteLine("I'm dead, you can't feed me :(");
            }
        }

        public String returnSpeciesAndName()
        {
            return Species + " " + Name;
        }

        public String returnNameAndOwner(string owner)
        {
            return Name + " " + owner;
        }
        public void TakeForWalk(double distance)
        {
            
            if (weight > 0)
            {
                weight -= distance;
                Console.WriteLine("thx for walk, bro");
                Console.WriteLine("my weight is now " + weight);
            }
            if (weight <= 0)
            {
                Console.WriteLine("I'm dead, you can't go for a walk with me :(");
            }
        }

    }
}
