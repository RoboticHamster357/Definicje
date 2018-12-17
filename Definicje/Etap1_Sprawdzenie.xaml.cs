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
    /// Logika interakcji dla klasy Etap1_Sprawdzenie.xaml
    /// </summary>
    public partial class Etap1_Sprawdzenie : Window
    {
        public Etap1_Sprawdzenie()
        {
            InitializeComponent();

            StreamReader czytacz1 = new StreamReader("czyPoprawne.txt");
            string wyniki = czytacz1.ReadToEnd();
            czytacz1.Close();
            string[] tabWynikow = wyniki.Split('~'); 

            TBgratulacje.Text=tabWynikow[2].ToString()+"\n"+"Liczba błędów: "+tabWynikow[1].ToString();

        }

        private void BDalej_Click(object sender, RoutedEventArgs e)
        {
            Etap2_instrukcja wnd = new Etap2_instrukcja();
            this.Close();
            wnd.Show();
        }

        private void BJeszcze_Raz_Click(object sender, RoutedEventArgs e)
        {
            Etap1_instrukcja wnd = new Etap1_instrukcja();
            this.Close();
            wnd.Show();
        }
    }
}
