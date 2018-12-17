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
    /// Logika interakcji dla klasy Etap3_sprawdzenie.xaml
    /// </summary>
    public partial class Etap3_sprawdzenie : Window
    {
        public Etap3_sprawdzenie()
        {
            InitializeComponent();
        }

        private void BDalej3_Click(object sender, RoutedEventArgs e)
        {
            Brawo wnd= new Brawo();
            this.Close();
            wnd.Show();
        }

        private void BJeszcze_raz3_Click(object sender, RoutedEventArgs e)
        {
            Etap3_instrukcja wnd = new Etap3_instrukcja();
            this.Close();
            wnd.Show();
        }
    }
}
