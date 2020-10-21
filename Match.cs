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



        public string Winning { 
            get 
            {
                if (this.Score1 > this.Score2) return Team1;
                if (this.Score1 < this.Score2) return Team2;
                else return "--";
            }
            set
            {
                if (this.Score1 > this.Score2) Winning= Team1;
                if (this.Score1 < this.Score2) Winning= Team2;
                else Winning = "--";
            }
        }
        public int TimeToEnd {
            get
            {
                return 90 - this.Completion;
            }
            set
            {
                TimeToEnd = 90 - this.Completion;
            }
        }
    }
}
