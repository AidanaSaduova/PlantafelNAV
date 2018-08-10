using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantafelNAV.ViewModel.Helpers
{
    public class Maschine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Mitarbeiter Mitarbeiter1 { get; set; }
        public Mitarbeiter Mitarbeiter2 { get; set; }
        public DateTime Begin { get; set; }
        public DateTime Ende { get; set; }
    }
}
