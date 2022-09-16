using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekretariat
{
    public partial class Form2 : Form
    {
        string text = " ";
        int ostatnie = 0;
        public Form2()
        {
            InitializeComponent();
            text = System.IO.File.ReadAllText("C:\\Users\\oktaw\\Downloads\\dane.txt");
            ostatnie = Int32.Parse(File.ReadLines("C:\\Users\\oktaw\\Downloads\\dane.txt").Last().ToString().Substring(0, 3));
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            text = System.IO.File.ReadAllText("C:\\Users\\oktaw\\Downloads\\dane.txt");
            TextWriter txt = new StreamWriter("C:\\Users\\oktaw\\Downloads\\dane.txt");
            ostatnie++;
            string dane= text+System.Environment.NewLine+ostatnie.ToString()+" "+imie_inp.Text+" "+nazwisko_inp.Text+" "+klasa_inp.Text+" ";
            txt.Write(dane);
            txt.Close();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            wynik_rich.Clear();
            string fileName = "C:\\Users\\oktaw\\Downloads\\dane.txt";

            string text = File.ReadAllText(fileName);
            string[] lines = text.Split(Environment.NewLine);
            object obiekt = kategoria_cmbbox.SelectedItem;
            string kategoria = Convert.ToString(obiekt);
            object obiekt2 = zadanie_cmbbox.SelectedItem;
            string kategoria2 = Convert.ToString(obiekt2);
            //wynik_rich.Text = kategoria;

            foreach (string line in lines)
            {
                
                if (kategoria == "Imie")
                {
                    
                    if (kategoria2 == "zaczyna się od")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[1].Substring(0, 1) == kryteria_inp.Text.Substring(0, 1))
                        {
                            wynik_rich.Text += System.Environment.NewLine+ line;
                        }

                    }
                    else if(kategoria2 == "zawiera")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[1].Contains(kryteria_inp.Text))
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }
                    }
                    else
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[1] == kryteria_inp.Text)
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }
                    }
                }else if (kategoria == "Nazwisko")
                {

                    if (kategoria2 == "zaczyna się od")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[2].Substring(0, 1) == kryteria_inp.Text.Substring(0, 1))
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }

                    }
                    else if (kategoria2 == "zawiera")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[2].Contains(kryteria_inp.Text))
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }
                    }
                    else
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[2] == kryteria_inp.Text)
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }
                    }
                }
                else if (kategoria == "Klasa")
                {

                    if (kategoria2 == "zaczyna się od")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[3].Substring(0, 1) == kryteria_inp.Text.Substring(0, 1))
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }

                    }
                    else if (kategoria2 == "zawiera")
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[3].Contains(kryteria_inp.Text))
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }
                    }
                    else
                    {
                        string[] ssize = line.Split(null); //Or myStr.Split()
                        if (ssize[3] == kryteria_inp.Text)
                        {
                            wynik_rich.Text += System.Environment.NewLine + line;
                        }
                    }
                }
            }
        }
    }
}
