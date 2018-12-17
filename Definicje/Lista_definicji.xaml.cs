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
    /// Logika interakcji dla klasy Lista_definicji.xaml
    /// </summary>
    public partial class Lista_definicji : Window
    {
        Dictionary<string, string> definicje = new Dictionary<string, string>();
        public Lista_definicji()
        {
            InitializeComponent();

            StreamReader czytacz = new StreamReader("definicje.txt");
            string calytekst = czytacz.ReadToEnd();
            czytacz.Close();
            string[] tab;
            tab = calytekst.Split('|');
            for (int i = 0; i < tab.Length; i++)
            {
                string[] tab1=new string[2];
                tab1 = tab[i].Split('~');
                if (tab1[0] != "")
                {
                    if (!definicje.ContainsKey(tab1[0]))
                    {
                        definicje.Add(tab1[0], tab1[1]); //Wyrzuca błąd przy próbie dodania drugiej takiej samej definicji
                        LBListaDefinicji.Items.Add(tab1[0]);
                    }

                    
                }
            }
        }

        private void BDodaj_Click(object sender, RoutedEventArgs e)
        {
            Dodaj_Definicje wnd = new Dodaj_Definicje();
            wnd.Show();
            this.Close();
        }

        private void BWybierz_Click(object sender, RoutedEventArgs e)
        {
            if (this.LBListaDefinicji.SelectedIndex >= 0)
            {
                if(definicje.ContainsKey(this.LBListaDefinicji.SelectedValue.ToString()))
                {
                    StreamWriter zapisywacz = new StreamWriter("uzywanaDefinicja.txt");
                    zapisywacz.Write(this.LBListaDefinicji.SelectedValue.ToString() + "~" + definicje[this.LBListaDefinicji.SelectedValue.ToString()]);
                    zapisywacz.Close();
                }
                Etap1_instrukcja wnd = new Etap1_instrukcja();
                wnd.Show();
                this.Close();
            }
        }

        private void BUsun_Click(object sender, RoutedEventArgs e)
        {
            if (this.LBListaDefinicji.SelectedIndex >= 0)
            {
                StreamReader czytacz = new StreamReader("definicje.txt");
                string calytekst = czytacz.ReadToEnd();
                czytacz.Close();
                string[] tab;
                tab = calytekst.Split('|');
                string nowytekst="";
                for (int i = 0; i < tab.Length; i++)
                {
                    string[] tab1 = new string[2];
                    tab1 = tab[i].Split('~');
                    if (tab1[0] == this.LBListaDefinicji.SelectedValue.ToString())
                    {
                        tab[i] = "";
                    }
                    if(tab[i]!="")
                    {
                        nowytekst = nowytekst + tab[i] + "|";
                    }
                }
                StreamWriter zapisywacz = new StreamWriter("definicje.txt");
                zapisywacz.Write(nowytekst);
                zapisywacz.Close();
                definicje.Remove(this.LBListaDefinicji.SelectedValue.ToString());
                this.LBListaDefinicji.Items.RemoveAt(LBListaDefinicji.SelectedIndex);
            }
        }

        private void LBListaDefinicji_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
