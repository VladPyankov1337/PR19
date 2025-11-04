using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINO_Pyankov.Modell
{
    public class Afisha
    {
        public int Id { get; set; }
        public int IdKinoteatr { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }

        public Afisha(int id, int idKinoteatr, string name, DateTime time, int price)
        {
            Id = id;
            IdKinoteatr = idKinoteatr;
            Name = name;
            Time = time;
            Price = price;
        } 
    }
}
