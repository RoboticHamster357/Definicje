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
using System.Windows.Shapes;
using System.IO;

namespace Definicje
{
    /// <summary>
    /// Logika interakcji dla klasy Etap2_instrukcja.xaml
    /// </summary>
    public partial class Etap2_instrukcja : Window
    {
        public Etap2_instrukcja()
        {
            InitializeComponent();
            StreamReader czytacz = new StreamReader("uzywanaDefinicja.txt");
            string wyswietlanaDef = czytacz.ReadToEnd();
            czytacz.Close();
            string[] tab;
            tab = wyswietlanaDef.Split('~');
            TBdefinicja.Text += tab[0].ToString() + "\n" + tab[1].ToString();
        }

        private void BRozpocznij2_Click(object sender, RoutedEventArgs e)
        {
            Etap2_wybierz_kluczowe wnd = new Etap2_wybierz_kluczowe();
            this.Close();
            wnd.Show();

        }
    }
}
