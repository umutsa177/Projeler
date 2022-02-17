using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Restoran
{
    public class Foods
    {
        public string name { get; set; }

        public int price { get; set; }

        public Foods(string name,int price)
        {
            this.name = name;
            this.price = price;
        }
    }

    public class Drinks: Foods
    {
        public string drink_name { get; set; }

        public int drink_price { get; set; }

        public Drinks(string name,int price): base(name,price)
        {
            drink_name = name;
            drink_price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Sweets: Foods
    {
        public string sweet_name { get; set; }

        public int sweet_price { get; set; }

        public Sweets(string name, int price) : base(name,price)
        {
            sweet_name = name;
            sweet_price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Foods food1 = new("corba", 15);

            Foods food2 = new("iskender", 37);

            Foods drink1 = new("ayran", 5);

            Foods drink2 = new("kola", 7);

            Foods sweet1 = new("kunefe", 45);

            Foods sweet2 = new("kadayif", 32);

            Foods bill = new("Bill", (food1.price+food2.price+drink1.price+drink2.price+sweet1.price+sweet2.price));

            string fileName = "Foods.json";
            string jsonString = JsonSerializer.Serialize(food1);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));

            string a = "Foods.json";
            string b = JsonSerializer.Serialize(food2);
            File.WriteAllText(a, b);
            Console.WriteLine(File.ReadAllText(a));

            string c = "Drinks.json";
            string d = JsonSerializer.Serialize(drink1);
            File.WriteAllText(c, d);
            Console.WriteLine(File.ReadAllText(c));

            string e = "Drinks.json";
            string f = JsonSerializer.Serialize(drink2);
            File.WriteAllText(e, f);
            Console.WriteLine(File.ReadAllText(e));

            string q = "Sweets.json";
            string w = JsonSerializer.Serialize(sweet1);
            File.WriteAllText(q, w);
            Console.WriteLine(File.ReadAllText(q));

            string x = "Sweets.json";
            string y = JsonSerializer.Serialize(sweet2);
            File.WriteAllText(x, y);
            Console.WriteLine(File.ReadAllText(x));

            string asd = "Foods.json";
            string v = JsonSerializer.Serialize(bill);
            File.WriteAllText(asd, v);
            Console.WriteLine(File.ReadAllText(asd));

        }
    }
}