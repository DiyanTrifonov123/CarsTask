using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Искаш ли да вкараш кола?: ");
            string command = Console.ReadLine().ToLower();
            List<Car> carsList = new List<Car>();
            int i = 1;

            while (command != "no" && command != "ne" && command != "не")
            {
                Console.Write($"Въведи марка на {i} кола: ");
                string brand = Console.ReadLine();

                Console.Write($"Въведи модел на {i} кола: ");
                string model = Console.ReadLine();

                Console.Write($"Въведи регистрационен номер на {i} кола: ");
                string license = Console.ReadLine();

                Console.Write($"Въведи година на {i} кола: ");
                int year = int.Parse(Console.ReadLine());

                Car car = new Car(brand, model, license, year);
                carsList.Add(car);
                Console.WriteLine();

                Console.Write("Искаш ли да продължиш да вкарваш коли?: ");
                command = Console.ReadLine().ToLower();
                Console.WriteLine();
                i++;
            }

            foreach (var item in carsList)
            {
                item.Print();
                item.IsEco();
                item.Introduce();
                Console.WriteLine();
            }

            if (Car.Counter > 1)
            {
                Console.WriteLine($"{Car.Counter} коли се състезават!");
                Console.WriteLine();
            }            
        }
    }
}
