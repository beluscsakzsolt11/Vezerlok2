using System.Collections.Generic;
using System.Windows;

namespace Vezerlok2
{
    public class Termek
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public int Ar { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dgAdatok.ItemsSource = new List<Termek>
            {
                new Termek { Nev = "Alma",   Kategoria = "Gyümölcs", Ar = 450 },
                new Termek { Nev = "Banán",  Kategoria = "Gyümölcs", Ar = 600 },
                new Termek { Nev = "Körte",  Kategoria = "Gyümölcs", Ar = 550 },
                new Termek { Nev = "Répa",   Kategoria = "Zöldség",  Ar = 300 },
                new Termek { Nev = "Uborka", Kategoria = "Zöldség",  Ar = 400 }
            };
        }

        private void Kuldes_Click(object sender, RoutedEventArgs e)
        {
            string nem = rbFerfi.IsChecked == true ? "Férfi" : "Nő";
            MessageBox.Show($"Felhasználónév: {txtFelhasznalo.Text}\nNem: {nem}", "Küldés");
        }

        private void Megnyitas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Megnyitás");
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mentés");
        }

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}