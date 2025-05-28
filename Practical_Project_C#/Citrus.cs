using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practical_Project_C_
{
    internal class Citrus : Fruit
    {
        /*
         * Create derived class Citrus
         */
        int? _vitaminC;

        public int? VitaminC { get => _vitaminC; set => _vitaminC = value; }

        public Citrus(string name, string color, int vitaminC) : base(name, color)
        {
            _vitaminC = vitaminC;
        }

        // In case if base constructor called
        public Citrus() : this("Unknown", "transparent", 0) { }

        public override void Input()
            {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter color: ");
            Color = Console.ReadLine();

            Console.Write("Enter amount of Vitamin C (grams): ");
            VitaminC = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine($"Fruit named {Name} is {Color} and contain {_vitaminC} grams of Vitamin C!");
        }
    }
}