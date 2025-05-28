namespace Practical_Project_C_
{
    /*
     * I will finish project (add overloads, work with I/O and Exceptions handling) later today, if still will not be graded !!!
     * I will finish project (add overloads, work with I/O and Exceptions handling) later today, if still will not be graded !!!
     * I will finish project (add overloads, work with I/O and Exceptions handling) later today, if still will not be graded !!!
     */

    internal class Program
    {
        static void Main()
        {
            List<Fruit> fruits = new List<Fruit>()
            {
                new Fruit("Apple", "Green"),
                new Fruit("Pear", "Yellow"),
                new Citrus("Avocado", "Lime", 0),
                new Citrus("Lemon", "Yellow", 9),
                new Citrus("Orange", "Orange", 4)
            };

            PrintYellow(fruits);
            SortByName(fruits);
            PrintAll(fruits);
        }

        static void PrintYellow(List<Fruit> list)
        {
            foreach (var fruit in list)
            {
                if (fruit.Color.ToLower() == "yellow") fruit.Print();
            }
        }

        static void SortByName(List<Fruit> list)
        {
            list.Sort((f1, f2) => f1.Name.CompareTo(f2.Name));
        }

        static void PrintAll(List<Fruit> list)
        {
            foreach (var fruit in list)
            {
                fruit.Print();
            }
        }
    }
}