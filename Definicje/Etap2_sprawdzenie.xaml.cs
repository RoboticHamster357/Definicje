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
    /// Logika interakcji dla klasy Etap2_sprawdzenie.xaml
    /// </summary>
    public partial class Etap2_sprawdzenie : Window
    {
        public Etap2_sprawdzenie()
        {
            InitializeComponent();
            StreamReader czytacz1 = new StreamReader("czyPoprawne.txt");
            string wyniki = czytacz1.ReadToEnd();
            czytacz1.Close();
            string[] tabWynikow = wyniki.Split('~');
            TBgratulacje.Text = tabWynikow[2].ToString() + "\n" + "Liczba błędów: " + tabWynikow[1].ToString();

            StreamReader czytacz2 = new StreamReader("poprawionaDef.txt");
            string poprawionaDef = czytacz2.ReadToEnd();
            czytacz2.Close();

            string[] tabPoprawiona = poprawionaDef.Split(' ');
            for (int i = 0; i < tabPoprawiona.Length; i++)
            {
                if (tabPoprawiona[i].EndsWith("#"))
                {
                    TextRange rangeOfText1 = new TextRange(tbPoprawiona.Document.ContentEnd, tbPoprawiona.Document.ContentEnd);
                    rangeOfText1.Text = tabPoprawiona[i].Trim('#') + " ";
                    rangeOfText1.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
                    rangeOfText1.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                }
                else
                {
                    TextRange rangeOfText1 = new TextRange(tbPoprawiona.Document.ContentEnd, tbPoprawiona.Document.ContentEnd);
                    rangeOfText1.Text = tabPoprawiona[i] + " ";
                    rangeOfText1.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);
                    rangeOfText1.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                }
            }
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
