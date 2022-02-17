using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Otobüs_Yolcu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Otobus o1 = new Otobus("Uludag", "ULUDAG", "55");
            Otobus o2 = new Otobus("Kamilkoc", "KAMILKOC", "60");
            Otobus o3 = new Otobus("Metro", "METRO", "50");

            Yolcular y1 = new Yolcular("Vehbi", "Koc", "1");
            Yolcular y2 = new Yolcular("Polat", "Alemdar", "12");
            Yolcular y3 = new Yolcular("Fatma", "Ozturk", "35");
            Yolcular y4 = new Yolcular("Turkan","Soray","23");


            y2.Addotobüs(o1);
            y1.Addotobüs(o3);
            o3.Addyolcu(y4);
            y3.Addotobüs(o2);

            string fileName = "Otobus-yolcu.json";
            string jsonString = JsonSerializer.Serialize(y1);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));

            string filename = "Otobus-yolcu.json";
            string jsonstring = JsonSerializer.Serialize(y2);
            File.WriteAllText(filename, jsonstring);
            Console.WriteLine(File.ReadAllText(filename));


            string file_Name = "Otobus-yolcu.json";
            string jsonstr = JsonSerializer.Serialize(y3);
            File.WriteAllText(file_Name, jsonstr);
            Console.WriteLine(File.ReadAllText(file_Name));

            string asd = "Otobus-yolcu.json";
            string qw = JsonSerializer.Serialize(y4);
            File.WriteAllText(asd, qw);
            Console.WriteLine(File.ReadAllText(asd));

        }
    }
}