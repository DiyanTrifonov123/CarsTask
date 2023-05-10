using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsZadacha
{
    internal class Car
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string licensePlate;

        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
            
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
        }

        public Car(string brand, string model, string license, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.LicensePlate = license;
            this.Year = year;
            counter++;
        }

        public void Print()
        {
            Console.WriteLine($"{this.Brand} {this.Model}: brum-brum-brum!");
        }

        public void IsEco()
        {
            if (this.Year >= 2000)
            {
                Console.WriteLine($"{this.Brand} {this.Model} е екологична!");
            }
            else
            {
                Console.WriteLine($"{this.Brand} {this.Model} не е екологична!");
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"Аз съм {this.Brand} {this.Model} с регистрационен номер" +
                $" {this.LicensePlate} и съм роден {this.Year} година!");
        }
    }
}
