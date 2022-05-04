using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbnaMaturaZadacha
{
    class Truck : Car
    {
        private int tonnage;

        public int Tonnage
        {
            get { return tonnage; }
            set { tonnage = value; }
        }

        public override double Price()
        {
            int years = DateTime.Now.Year - Year;
            double price = Value;

            if (years <= 5)
            {
                price *= 1;
            }
            else if (years > 5 && Tonnage <= 5)
            {
                price *= 0.3;
            }
            else if (years > 5 && Tonnage <= 10)
            {
                price *= 0.6;
            }
            else if (years > 5 && Tonnage > 10)
            {
                price *= 0.80;
            }

            return price;
        }
    }
}
