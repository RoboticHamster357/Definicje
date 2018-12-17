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
    /// Logika interakcji dla klasy Etap1_instrukcja.xaml
    /// </summary>
    public partial class Etap1_instrukcja : Window
    {

        public Etap1_instrukcja()
        {
            InitializeComponent();
            StreamReader czytacz = new StreamReader("uzywanaDefinicja.txt");
            string wyswietlanaDef = czytacz.ReadToEnd();
            czytacz.Close();
            string[] tab;
            tab = wyswietlanaDef.Split('~');
            TBDefinicja.Text += tab[0].ToString() + "\n" + tab[1].ToString();
        }

        private void BRozpocznij1_Click(object sender, RoutedEventArgs e)
        {
            Etap1_uzupelnij wnd = new Etap1_uzupelnij();
            this.Close();
            wnd.Show();
        }

        private void TBInstrukcja_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
