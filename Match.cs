using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ListboxUndEineListeVonErgebnisse
{
    public class Match
    {
        //Properties
        public int Score1 { get; set; }
        public string Team1 { get; set; }
        public int Score2 { get; set; }
        public string Team2 { get; set; }

        public int Completion { get; set; }
    }
}
