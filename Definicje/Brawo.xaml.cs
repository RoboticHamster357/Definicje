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
    /// Logika interakcji dla klasy Brawo.xaml
    /// </summary>
    public partial class Brawo : Window
    {
        public Brawo()
        {
            InitializeComponent();
            TBGratulacje.Text = "Gratuluję!\n" +
                "Udało ci się ukończyć wszystkie etapy. ";
        }

        private void BZakoncz_Click(object sender, RoutedEventArgs e)
        {
            Lista_definicji wnd = new Lista_definicji();
            this.Close();
            wnd.Show();
        }
    }
}
