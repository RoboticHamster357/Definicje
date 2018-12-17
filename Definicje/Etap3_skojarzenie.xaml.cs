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
    /// Logika interakcji dla klasy Etap3_skojarzenie.xaml
    /// </summary>
    public partial class Etap3_skojarzenie : Window
    {
        public Etap3_skojarzenie()
        {
            InitializeComponent();
        }

        private void BSprawdz3_Click(object sender, RoutedEventArgs e)
        {
            Etap3_sprawdzenie wnd = new Etap3_sprawdzenie();
            this.Close();
            wnd.Show();
        }
    }
}
