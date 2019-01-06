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
    /// Logika interakcji dla klasy Etap3_instrukcja.xaml
    /// </summary>
    public partial class Etap3_instrukcja : Window
    {
        public Etap3_instrukcja()
        {
            InitializeComponent();
            StreamReader czytacz = new StreamReader("uzywanaDefinicja.txt");
            string wyswietlanaDef = czytacz.ReadToEnd();
            czytacz.Close();
            string[] tab;
            tab = wyswietlanaDef.Split('~');
            TBdefinicja.Text += tab[0].ToString() + "\n" + tab[1].ToString();
            TBinstrukcja.Text = "W trzecim etapie masz za zadanie skorzystać ze swojej kreatywności. " +
                "Wymyśl kilka skojarzeń związanych z definicją. Daj się ponieść fantazji, im mniej oczywiste i bardziej zwariowane tym lepiej. " +
                "Na podstawie wyświetlanych skojarzeń spróbuj odtworzyć definicję. Daj z siebie wszystko, powodzenia! ";
        }

        private void BDalej3_Click(object sender, RoutedEventArgs e)
        {
            Etap3_wypisz_skojarzenia wnd = new Etap3_wypisz_skojarzenia();
            this.Close();
            wnd.Show();
        }
    }
}
