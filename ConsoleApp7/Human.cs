

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        private decimal salary;
        private DateTime dateTime;
        private Car automobile = new Car();
        public decimal Salary
        {
           
            set
            {
                
                if (value > 0){ 
                 salary = value;
                    Console.WriteLine("Information has been added");
                    dateTime = DateTime.Now;
                }
                else{
                    Console.WriteLine("Don't cheat");
                }
                
            }
            get
            {
             
                Console.WriteLine("Last time modifide: " + dateTime);
                return salary; 
                
            }
        }

        public Car Automobile
        {
            get
            {
                return automobile;
            }

            set
            {
                if (salary < value.Value)
                {
                    Console.WriteLine("You can't afford this car");
                }
                else
                {
                    
                    Console.WriteLine("Car has been added");
              }
            }
        }
        
      
    }
}
