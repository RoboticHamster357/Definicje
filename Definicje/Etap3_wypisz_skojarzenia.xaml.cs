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
    /// Logika interakcji dla klasy Etap3_wypisz_skojarzenia.xaml
    /// </summary>
    public partial class Etap3_wypisz_skojarzenia : Window
    {
        public Etap3_wypisz_skojarzenia()
        {
            InitializeComponent();
            StreamReader czytacz = new StreamReader("uzywanaDefinicja.txt");
            string wyswietlanaDef = czytacz.ReadToEnd();
            czytacz.Close();
            string[] tab;
            tab = wyswietlanaDef.Split('~');
            TBdefinicja.Text += tab[0].ToString() + "\n" + tab[1].ToString();
        }

        private void BDalej_Click(object sender, RoutedEventArgs e)
        {
            string skojarzenia = TBSkojarzenia.Text.ToString();
            StreamWriter zapisywacz = new StreamWriter("skojarzenia.txt");
            zapisywacz.Write(skojarzenia);
            zapisywacz.Close();
            Etap3_skojarzenie wnd = new Etap3_skojarzenie();
            this.Close();
            wnd.Show();
        }

        private void TBSkojarzenia_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TBSkojarzenia_GotFocus;
        }
    }
}
