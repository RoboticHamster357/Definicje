﻿using System;
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
    /// Logika interakcji dla klasy Etap3_skojarzenie.xaml
    /// </summary>
    public partial class Etap3_skojarzenie : Window
    {
        string[] tablicaSlow;
        TextBox[] textBoxes = new TextBox[35];
        string[] tab;
        string poprawionaDef;

        public Etap3_skojarzenie()
        {
            InitializeComponent();
            textBoxes[0] = textBox0; textBoxes[1] = textBox1; textBoxes[2] = textBox2; textBoxes[3] = textBox3; textBoxes[4] = textBox4; textBoxes[5] = textBox5; textBoxes[6] = textBox6; textBoxes[7] = textBox7; textBoxes[8] = textBox8; textBoxes[9] = textBox9; textBoxes[10] = textBox10;
            textBoxes[11] = textBox11; textBoxes[12] = textBox12; textBoxes[13] = textBox13; textBoxes[14] = textBox14; textBoxes[15] = textBox15; textBoxes[16] = textBox16; textBoxes[17] = textBox17; textBoxes[18] = textBox18; textBoxes[19] = textBox19; textBoxes[20] = textBox20; textBoxes[21] = textBox21;
            textBoxes[22] = textBox22; textBoxes[23] = textBox23; textBoxes[24] = textBox24; textBoxes[25] = textBox25; textBoxes[26] = textBox26; textBoxes[27] = textBox27; textBoxes[28] = textBox28; textBoxes[29] = textBox29; textBoxes[30] = textBox30; textBoxes[31] = textBox31; textBoxes[32] = textBox32;
            textBoxes[33] = textBox11; textBoxes[34] = textBox34;

            StreamReader czytacz1 = new StreamReader("skojarzenia.txt");
            string slowaKluczowe = czytacz1.ReadToEnd();
            czytacz1.Close();
            tbPodpowiedz.Text = slowaKluczowe;

            StreamReader czytacz = new StreamReader("uzywanaDefinicja.txt");
            string wyswietlanaDef = czytacz.ReadToEnd();
            czytacz.Close();

            tab = wyswietlanaDef.Split('~');


            tablicaSlow = tab[1].Split(' ');
            for (int i = 0; i < tablicaSlow.Length; i++)
            {
                tablicaSlow[i] = tablicaSlow[i].Trim('.', ',', '(', ')', '[', ']', '{', '}', '-', ';', ':', ' ');
            }

            int licznik = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (licznik < tablicaSlow.Length)
                    {
                        textBoxes[licznik].Visibility = Visibility.Visible;
                        licznik++;
                    }
                }
            }
        }

        private void BSprawdz3_Click(object sender, RoutedEventArgs e)
        {

            int poprawne = 0;
            int niepoprawne = 0;
            string gratulacje;
            int[] czyRowne = new int[tablicaSlow.Length];
            string[] tablicaSlow1 = tab[1].Split(' ');
            for (int i = 0; i < tablicaSlow.Length; i++)
            {
                czyRowne[i] = string.Compare(tablicaSlow[i], textBoxes[i].Text, true);
                if (czyRowne[i] == 0)
                {
                    poprawne++;
                }
                else
                {
                    tablicaSlow1[i] += "#";
                    niepoprawne++;
                }
            }
            if (niepoprawne < 1)
            {
                gratulacje = "Gratuluję! Udało się!";
            }
            else
            {
                gratulacje = "Niestety nie udało ci się uzupełnić poprawnie :(";
            }

            for (int i = 0; i < tablicaSlow1.Length; i++)
            {
                poprawionaDef += tablicaSlow1[i] + " ";
            }

            StreamWriter zapisywacz = new StreamWriter("czyPoprawne.txt");
            zapisywacz.Write(poprawne + "~" + niepoprawne + "~" + gratulacje);
            zapisywacz.Close();

            StreamWriter zapisywacz1 = new StreamWriter("poprawionaDef.txt");
            zapisywacz1.Write(poprawionaDef);
            zapisywacz1.Close();

            Etap3_sprawdzenie wnd = new Etap3_sprawdzenie();
            this.Close();
            wnd.Show();
        }
    }
}
