using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINO_Pyankov.Modell
{
    public class Kinoteatr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountZal { get; set; }
        public int Count { get; set; }

        public Kinoteatr(int id, string name, int countZal, int count)
        {
            Id = id;
            Name = name;
            CountZal = countZal;
            Count = count;
        }
    }
}
