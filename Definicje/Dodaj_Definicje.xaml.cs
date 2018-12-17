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
    /// Logika interakcji dla klasy Dodaj_Definicje.xaml
    /// </summary>
    public partial class Dodaj_Definicje : Window
    {
        public Dodaj_Definicje()
        {
            InitializeComponent();
        }

        private void BDodaj_Definicje2_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter pisacz = new StreamWriter("definicje.txt",true);
            string tekst = TBCo_Definiujesz.Text + "~" + TBTresc_Definicji.Text+"|";
            pisacz.Write(tekst);
            pisacz.Close();
            Lista_definicji wnd = new Lista_definicji();
            this.Close();
            wnd.Show();
        }

        private void TBCo_Definiujesz_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBTresc_Definicji_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
