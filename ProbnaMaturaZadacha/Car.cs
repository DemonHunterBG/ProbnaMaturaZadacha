using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbnaMaturaZadacha
{
    class Car
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private int mileage;

        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        private double value_;

        public double Value
        {
            get { return value_; }
            set { value_ = value; }
        }

        public virtual double Price()
        {
            int years = DateTime.Now.Year - Year;
            double price = Value;

            if (years <= 3)
            {
                price *= 0.8;
            }
            else if (years <= 6)
            {
                price *= 0.6;
            }
            else if (years >= 7)
            {
                price *= 0.3;
            }

            return price;
        }
    }
}
