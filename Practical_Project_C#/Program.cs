using System.Text.Json;

namespace Practical_Project_C_
{
    /*
     * This is Practical Project
     * Work with list of fruits
     * save them to file
     * exceptions handling, etc
     */

    internal class Program
    {
        static void Main()
        {
            List<Fruit> fruits;

            // Deserialize from file if possible
            if (File.Exists("fruits.json"))
            {
                string jsonFromFile = File.ReadAllText("fruits.json");
                fruits = JsonSerializer.Deserialize<List<Fruit>>(jsonFromFile);
            }
            else
            {
                fruits = new List<Fruit>()
                {
                    new Fruit("Apple", "Green"),
                    new Fruit("Pear", "Yellow"),
                    new Citrus("Avocado", "Lime", 0),
                    new Citrus("Lemon", "Yellow", 9),
                    new Citrus("Orange", "Orange", 4)
                };
            }

            // All methods with "to do one job" concept and user friendly, because of ex handling
            try
            {
                fruits[1].Input();
                fruits[1].Print();
                fruits[2].Input();
                fruits[2].Print();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }
            try
            {

                // set value for elment from file and then rewrite file
                using (StreamReader reader = new StreamReader("fruit.txt"))
                {
                    fruits[3].Input(reader);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File deleated or corruped");
            }

            using (StreamWriter writer = new StreamWriter("fruit.txt"))
            {
                fruits[4].Print(writer);
            }
            PrintYellow(fruits);
            SortByName(fruits);
            PrintAll(fruits);

            string json = JsonSerializer.Serialize(fruits);
            File.WriteAllText("fruits.json", json);
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