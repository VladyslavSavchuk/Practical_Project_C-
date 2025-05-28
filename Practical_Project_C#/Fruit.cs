namespace Practical_Project_C_
{
    public class Fruit
    {
        string _name;
        string _color;

        public string Name { get => _name; set => _name = value; }
        public string Color { get => _color; set => _color = value; }

        public Fruit(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public virtual void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter color: ");
            Color = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Fruit named {_name} is {_color}");
        }

        public override string ToString()
        {
            return $"Name: {_name} \nColor: {_color}";
        }
    }
}
