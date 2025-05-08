using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private string _model = "";
        private string _brand = "";
        private bool isLusury;
        readonly int num = 1;
        const int num2 = 0;

        public string Model { get { return _model; } set { _model = value; } }
        public string Brand 
        {
            get
            {
                if (isLusury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        public bool IsLusury { get { return isLusury; } set { isLusury = value; } }


        public Car(string model, string brand, bool isLusury)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
            this.isLusury = isLusury;
        }

        public void Drive()
        {
            Console.WriteLine($"I am driving {Brand}.");
        }

    }
}
