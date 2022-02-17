using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobüs_Yolcu
{
    public class Otobus
    {
        public string Name { get; set; }

        public string Marka { get; set; }

        public string Capacity { get; set; }

        public List<Yolcular> Yolcular { get; set; } = new List<Yolcular>();

        public Otobus(string name,string marka, string capacity)
        {
            Name = name;
            Marka = marka;
            Capacity = capacity;
        }

        public Otobus(string name, string marka, string capacity, Yolcular yolcu) : this(name,marka,capacity) => Addyolcu(yolcu);

        public void Addyolcu(Yolcular yolcu)
        {
            if (Yolcular.Exists(q => q.Name == yolcu.Name)) return;

            if (Yolcular.Exists(n => n.Surname == yolcu.Surname)) return;
            
            Yolcular.Add(yolcu);
        }
    }
}