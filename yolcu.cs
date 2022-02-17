using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobüs_Yolcu
{
    public class Yolcular
    {
        public string Name { get; set;}

        public string Surname { get; set; }

        public string Seat_no { get; set; }

        public List<Otobus> Otobus { get; private set; } = new List<Otobus>();

        public Yolcular(string name, string surname,string seat_no)
        {
            Name = name;
            Surname = surname;
            Seat_no = seat_no;
        }

        public Yolcular(string name, string surname, string seat_no, Otobus otobüs) : this(name, surname, seat_no)
        {
            otobüs.Addyolcu(this);

            Otobus.Add(otobüs);
        }

        public void Addotobüs(Otobus otobüs)
        {
            if (Otobus.Exists(o => o.Name == otobüs.Name)) return;

            Otobus.Add(otobüs);
        }
    }
}