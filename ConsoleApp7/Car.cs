using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    public class Car
    {
        public String Make;
        public String Model;
        public Decimal Value;
        public String Color;

        public override string ToString()
        {
            return "Car: " + Make + " " + Model + " " + Value + " " + Color;
        }
        public override bool Equals(Object obj)
        {
            if (Make == Model)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
