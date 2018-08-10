using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantafelNAV.ViewModel.Helpers
{
    public class Auftrag
    {
        public int ID { get; set; }
        public DateTime Beginn { get; set; }
        public DateTime End { get; set; }
        public Maschine Schmelzofen { get; set; }
        public Maschine CNCDrehmaschine { get; set; }
        public Maschine Ausrichtestation { get; set; }
        public Maschine Fraesmaschine { get; set; }
        public Maschine Pruefmaschine { get; set; }
        public string Status { get; set; }

    }
}
