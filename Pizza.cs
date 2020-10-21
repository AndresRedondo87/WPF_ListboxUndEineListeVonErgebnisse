using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_ListboxUndEineListeVonErgebnisse
{
    public class Pizza : INotifyPropertyChanged
    {
        private bool chosen;
        public string Zutat { get; set; }
        public bool Chosen 
        { 
            get
            {
                return chosen;
            }
            set
            {
                this.chosen = value;
                OnPropertyChanged("Chosen"); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            // was wenn property leer ist??? um sicher zu gehen!
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
