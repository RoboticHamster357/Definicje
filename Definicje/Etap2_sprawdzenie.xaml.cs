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

namespace Definicje
{
    /// <summary>
    /// Logika interakcji dla klasy Etap2_sprawdzenie.xaml
    /// </summary>
    public partial class Etap2_sprawdzenie : Window
    {
        public Etap2_sprawdzenie()
        {
            InitializeComponent();
        }

        private void BDalej_2_Click(object sender, RoutedEventArgs e)
        {
            Etap3_instrukcja wnd = new Etap3_instrukcja();
            wnd.Show();
            this.Close();
        }

        private void BJeszcze_raz2_Click(object sender, RoutedEventArgs e)
        {
            Etap2_instrukcja wnd = new Etap2_instrukcja();
            wnd.Show();
            this.Close();
        }
    }
}
