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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Definicje
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TBPowitanie.Text = "Witaj!\nSkoro tu trafiłeś to znaczy, że chciałbyś nauczyć się czegoś nowego. Nauka na pamięć nie jest łatwa. " +
                "Ludzie często czytają tekst w kółko i mimo wielokrotnego powtarzania przynosi to marne efekty. " +
                "Korzystając z tej aplikacji najważniejsze jest to, że zamiast czytać tekst sam próbujesz go sobie przypomnieć. " +
                "Bądź dla siebie wyrozumiały, nie wszystkiego da się nauczyć od razu. " +
                "Kiedy przejdziesz dalej będziesz mógł dodać definicję, której chcesz się nauczyć lub wybrać jedną z już dodanych. " +
                "Nie oszukuj i nie pomagaj sobie zaglądając do treści definicji już podczas realizowania jednego z etapów. " +
                "Powodzenia!";
        }

     

        private void BDalej_Click(object sender, RoutedEventArgs e)
        {
            Lista_definicji wnd = new Lista_definicji();
            this.Close();
            wnd.Show();
        }
    }
}
