using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ListboxUndEineListeVonErgebnisse
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // INotifyPropertyChanged Interface-
        // es meldet sich wenn eine Pror geändert worden ist
        public Pizza MeinePizza { get; set; }
        // WAS SOWAS FÜR UNS BEDEUTET WIRD NICHT RICHTIG ERKLÄRT...


        //checkboxen ERWEITERUING VERSUCH
        private List<Pizza> lstZutaten = new List<Pizza>();

        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>
            {
                new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 },
                new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 },
                new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 },
                new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 },
                new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 },
                new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 },
                new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 },
                new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 },
                new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 },
                new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 },
                new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 },
                new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 },
                new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 },
                new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 },
                new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 },
                new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 }
            };
            /// Mit viele Einträge macht der Listbox eine automatische Vertikale Scrollbar hinzugefügt

            lbMatches.ItemsSource = matches;
            // Die Listbox in XAML lbMatches  braucht ein Items source, so zu sagen eine Quelle fur die Daten zum anzeigen.
            // wir zuweisen dann die Liste die wir gerade eingetragen haben
            // in XAML <ListBox Name="lbMatches" HorizontalContentAlignment="Center">

            //ComboBox
            cbColours.ItemsSource = typeof(Colors).GetProperties();
            // WIEDER GAR NICHT ERKLÄRT DEN typeof oder woher Colors und nicht Color... oder wieso GetProperties und nicht GetProperty...


            //checkboxen ERWEITERUING VERSUCH
            lstZutaten.Add(new Pizza() { Zutat = "Salami", Chosen = false });
            lstZutaten.Add(new Pizza() { Zutat = "Paprika", Chosen = false });
            lstZutaten.Add(new Pizza() { Zutat = "Tomate", Chosen = false });
            lstZutaten.Add(new Pizza() { Zutat = "Mozzarella", Chosen = false });
            lstZutaten.Add(new Pizza() { Zutat = "Champignons", Chosen = false });
            lstZutaten.Add(new Pizza() { Zutat = "Thunfisch", Chosen = false });
            MyZutaten.ItemsSource = lstZutaten;

            this.DataContext = lstZutaten;
        
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Match anzeigen mit mehr Info (Theoretisch)
            if(lbMatches.SelectedItem != null)      //MUSS ETWAS AUSGEWÄHLT SEIN; SONST GIBT ES EXCEPTIONS!!
            {
                //MessageBox.Show($"Ausgewähltes Spiel: \n\n" +
                //    $"{(lbMatches.SelectedItem as Match).Team1} {(lbMatches.SelectedItem as Match).Score1} " +
                //    $"- {(lbMatches.SelectedItem as Match).Score2} {(lbMatches.SelectedItem as Match).Team2} " +
                //    $" Minute {(lbMatches.SelectedItem as Match).Completion}' ");
                DisplayInfo(sender, e);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einem Spiel aus!");
            }
        }

        private void lbMatches_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DisplayInfo(sender, e);
        }

        private void DisplayInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Ausgewähltes Spiel: \n\n" +
                   $"{(lbMatches.SelectedItem as Match).Team1} {(lbMatches.SelectedItem as Match).Score1} " +
                   $"- {(lbMatches.SelectedItem as Match).Score2} {(lbMatches.SelectedItem as Match).Team2} " +
                   $" Minute {(lbMatches.SelectedItem as Match).Completion}' ");
        }

        private void cbAllToppings_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllToppings.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
            cbMozarella.IsChecked = newVal;

        }

        private void cbAllToppings_Unchecked(object sender, RoutedEventArgs e)
        {
            // ?? nichts machen?
        }

        //Selber erstellt
        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllToppings.IsChecked = null;
            if((cbSalami.IsChecked == true )&&(cbMozarella.IsChecked == true) && (cbMushrooms.IsChecked == true))
            {
                cbAllToppings.IsChecked = true;
            }
            if ((cbSalami.IsChecked == false) && (cbMozarella.IsChecked == false) && (cbMushrooms.IsChecked == false))
            {
                cbAllToppings.IsChecked = true;
            }
        }


        //checkboxen ERWEITERUING VERSUCH
        private void cbAll_Checked(object sender, RoutedEventArgs e)
        {
            bool newValue = (cbAll.IsChecked == true);
            lstZutaten.ForEach(x => x.Chosen = newValue);
        }
        private void cbAll_Unchecked(object sender, RoutedEventArgs e)
        {
            // ?? nichts machen?
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            bool oneChecked = false;
            bool oneNotChecked = false;
            foreach (Pizza item in MyZutaten.Items)
            {
                if (item.Chosen == true)
                {
                    oneChecked = true;
                }
                else if (item.Chosen == false)
                {
                    oneNotChecked = true;
                }
            }

            if (!oneChecked)
            {
                cbAll.IsChecked = false;
            }
            if (!oneNotChecked)
            {
                cbAll.IsChecked = true;
            }
            if (oneChecked && oneNotChecked)
            {
                cbAll.IsChecked = null;
            }
        }
    }
}
