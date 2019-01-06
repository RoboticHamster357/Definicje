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
    /// Logika interakcji dla klasy Etap2_wybierz_kluczowe.xaml
    /// </summary>
    public partial class Etap2_wybierz_kluczowe : Window
    {
        int ileSlow=0;
        int maxSlow = 0;
        string[] tablicaSlow;
        Button[] buttons=new Button[35];

        public Etap2_wybierz_kluczowe()
        {
            InitializeComponent();
            buttons[0] = button0; buttons[1] = button1; buttons[2] = button2; buttons[3] = button3; buttons[4] = button4; buttons[5] = button5; buttons[6] = button6; buttons[7] = button7; buttons[8] = button8; buttons[9] = button9; buttons[10] = button10;
            buttons[11] = button11; buttons[12] = button12; buttons[13] = button13; buttons[14] = button14; buttons[15] = button15; buttons[16] = button16; buttons[17] = button17; buttons[18] = button18; buttons[19] = button19; buttons[20] = button20; buttons[21] = button21;
            buttons[22] = button22; buttons[23] = button23; buttons[24] = button24; buttons[25] = button25; buttons[26] = button26; buttons[27] = button27; buttons[28] = button28; buttons[29] = button29; buttons[30] = button30; buttons[31] = button31; buttons[32] = button32;
            buttons[33] = button33; buttons[34] = button34;

            StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt");
            zapisywacz.Write("");
            zapisywacz.Close();
            StreamReader czytacz = new StreamReader("uzywanaDefinicja.txt");
            string wyswietlanaDef = czytacz.ReadToEnd();
            czytacz.Close();
            string[] tab;
            tab = wyswietlanaDef.Split('~');


            tablicaSlow = tab[1].Split(' ');
            maxSlow = tablicaSlow.Length / 4;

            int licznik = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (licznik < tablicaSlow.Length)
                    {
                        buttons[licznik].Visibility = Visibility.Visible;
                        buttons[licznik].Content = tablicaSlow[licznik].ToString();
                        licznik++;
                    }
                }
            }
            for (int i = 0; i < tablicaSlow.Length; i++)
            {
                tablicaSlow[i] = tablicaSlow[i].Trim('.', ',', '(', ')', '[', ']', '{', '}', '-', ';', ':', ' ');
            }
        }

        private void BWybierz_Click(object sender, RoutedEventArgs e)
        {
            Etap2_kluczowe wnd = new Etap2_kluczowe();
            this.Close();
            wnd.Show();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if(ileSlow<=maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt",true);
                zapisywacz.Write(button0.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button0.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button1.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button1.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button2.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button2.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button3.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button3.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button4.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button4.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button5.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button5.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button6.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button6.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button7.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button7.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button8.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button8.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button9.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button9.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button10.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button10.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button11.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button11.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button12.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button12.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button13.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button13.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button14.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button14.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button15.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button15.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button16.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button16.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button17.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button17.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button18.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button18.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button19.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button19.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button20.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button20.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button21.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button21.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button22.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button22.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button23.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button23.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button24_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button24.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button24.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button25_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button25.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button25.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button26_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button26.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button26.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button27_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button27.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button27.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button28_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button28.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button28.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button29_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button29.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button29.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button30_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button30.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button30.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button31_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button31.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button31.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button32_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button32.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button32.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button33_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button33.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button33.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }
        private void Button34_Click(object sender, RoutedEventArgs e)
        {
            ileSlow++;
            if (ileSlow <= maxSlow)
            {
                StreamWriter zapisywacz = new StreamWriter("slowaKluczowe.txt", true);
                zapisywacz.Write(button34.Content.ToString());
                zapisywacz.Write("~");
                zapisywacz.Close();
                tbkluczowe.Text = tbkluczowe.Text + button34.Content + " ";
            }
            else
            {
                MessageBox.Show("Wybrano już wszystkie słowa kluczowe");
            }
        }

        }
    }

