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
        public MainWindow()
        {
            InitializeComponent();

            List < Match > matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 });
            matches.Add(new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 });
            matches.Add(new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 });


            matches.Add(new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 });
            matches.Add(new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 });
            matches.Add(new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 });
            matches.Add(new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 });
            matches.Add(new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 });
            matches.Add(new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 });
            matches.Add(new Match() { Team1 = "Real Madrid", Team2 = "Bayern München", Score1 = 5, Score2 = 2, Completion = 82 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "BBVB", Score1 = 1, Score2 = 1, Completion = 15 });
            matches.Add(new Match() { Team1 = "Juventus", Team2 = "Bacelona", Score1 = 2, Score2 = 0, Completion = 50 });
            matches.Add(new Match() { Team1 = "Atlético Madrid", Team2 = "Bayern Leverkusen", Score1 = 1, Score2 = 0, Completion = 89 });
            /// Mit viele Einträge macht der Listbox eine automatische Vertikale Scrollbar hinzugefügt

            lbMatches.ItemsSource = matches;
            // Die Listbox in XAML lbMatches  braucht ein Items source, so zu sagen eine Quelle fur die Daten zum anzeigen.
            // wir zuweisen dann die Liste die wir gerade eingetragen haben
            // in XAML <ListBox Name="lbMatches" HorizontalContentAlignment="Center">
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Match anzeigen mit mehr Info (Theoretisch)
            if(lbMatches.SelectedItem != null)      //MUSS ETWAS AUSGEWÄHLT SEIN; SONST GIBT ES EXCEPTIONS!!
            {
                MessageBox.Show($"Ausgewähltes Spiel: \n\n" +
                    $"{(lbMatches.SelectedItem as Match).Team1} {(lbMatches.SelectedItem as Match).Score1} " +
                    $"- {(lbMatches.SelectedItem as Match).Score2} {(lbMatches.SelectedItem as Match).Team2} " +
                    $"  {(lbMatches.SelectedItem as Match).Completion}' ");
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einem Spiel aus!");
            }
        }
    }
}
