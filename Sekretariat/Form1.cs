namespace Sekretariat
{
    public partial class Form1 : Form
    {
        int random_number = 0;
        string number_text = "mxyxw";
        public Form1()
        {
            InitializeComponent();
            weryfikacja_img.Image = Image.FromFile("C:/Users/oktaw/Desktop/zdjecia/1.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user_input.Text=="admin" && password_input.Text=="Qwerty1@34" && kod_inp.Text==number_text)
            {
                Form1 f1 = new Form1();
                Form2 f2 = new Form2();
                f1.Close();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Logowanie nie udane");
            }
        }

        private void losuj_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            random_number = new Random().Next(1, 7); // Generates a number between 1 to 10
            weryfikacja_img.Image = Image.FromFile("C:/Users/oktaw/Desktop/zdjecia/"+random_number.ToString()+".png");
            switch (random_number)
            {
                case 1:
                    number_text = "mxyxw";
                    break;
                case 2:
                    number_text = "b5nmm";
                    break;
                case 3:
                    number_text = "74853";
                    break;
                case 4:
                    number_text = "cg5dd";
                    break;
                case 5:
                    number_text = "x3deb";
                    break;
                case 6:
                    number_text = "befbd";
                    break;
                case 7:
                    number_text = "c7gb3";
                    break;
            }
        }
    }
}