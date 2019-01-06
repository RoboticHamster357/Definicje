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
            TBInstrukcja.Text = "W pierwszym etapie uzupełnij brakujące słowa w wybranej przez ciebie definicji. Najpierw dokładnie przeczyataj wyświetloną definicję. " +
                "Kiedy uznasz, że jesteś gotowy rozpocznij pierwszy etap. Jeżeli nie uda ci się za pierwszym razem, nie martw się. Możesz spróbować jeszcze raz. " +
                "Jeżeli uważasz, że jesteś gotowy przejść dalej możesz to zrobić nawet jeżeli nie udało ci się bezbłędnie uzupełnić definicji. Powodzenia!";
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
