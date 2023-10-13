namespace ArabaOyunu
{
    public partial class Form1 : Form
    {
        int yolHizi;
        int trafikHizi;
        int oyuncuHizi = 12;
        int puan;
        int arabalar;
        bool solaGit, sagaGit;
        Random rndm = new Random();
        Random arabaPozisyon = new Random();

        public Form1()
        {
            InitializeComponent();
            Basla();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solaGit = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solaGit = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Puan: " + puan;
            puan++;
            if (solaGit == true && oyuncu.Left > 10)
            {
                oyuncu.Left -= oyuncuHizi;
            }
            if (sagaGit == true && oyuncu.Left < 480)
            {
                oyuncu.Left += oyuncuHizi;
            }
            yol1.Top += yolHizi;
            yol2.Top += yolHizi;
            if (yol2.Top > 519)
            {
                yol2.Top = -519;
            }
            if (yol1.Top > 519)
            {
                yol1.Top = -519;
            }
            bot_araba_1.Top += trafikHizi;
            bot_araba_2.Top += trafikHizi;

            if (bot_araba_1.Top > 530)
            {
                ArabaDegistir(bot_araba_1);
            }
            if (bot_araba_2.Top > 530)
            {
                ArabaDegistir(bot_araba_2);
            }
            if (oyuncu.Bounds.IntersectsWith(bot_araba_1.Bounds) || oyuncu.Bounds.IntersectsWith(bot_araba_2.Bounds))
            {
                OyunBitis();
            }
        }
        private void ArabaDegistir(PictureBox araba)
        {
            arabalar = rndm.Next(1, 8);
            switch (arabalar)
            {
                case 1:
                    araba.Image = Properties.Resources.gri_araba;
                    break;
                case 2:
                    araba.Image = Properties.Resources.turuncu_araba;
                    break;
                case 3:
                    araba.Image = Properties.Resources.mavi_kamyon;
                    break;
                case 4:
                    araba.Image = Properties.Resources.sarý_araba;
                    break;

            }

            araba.Top = arabaPozisyon.Next(100, 400) * -1;
            if ((string)araba.Tag == "solAraba")
            {
                araba.Left = arabaPozisyon.Next(5, 200);
            }
            if ((string)araba.Tag == "sagAraba")
            {
                araba.Left = arabaPozisyon.Next(245, 422);
            }
        }
        private void OyunBitis()
        {
            timer1.Stop();
            button1.Enabled = true;
        }
        private void Basla()
        {
            button1.Enabled = false;
            solaGit = false;
            sagaGit = false;
            puan = 0;
            yolHizi = 12;
            trafikHizi = 15;

            bot_araba_1.Top = arabaPozisyon.Next(200, 500) * -1;
            bot_araba_1.Left = arabaPozisyon.Next(12, 180);

            bot_araba_2.Top = arabaPozisyon.Next(200, 500) * -1;
            bot_araba_2.Left = arabaPozisyon.Next(250, 413);

            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basla();
        }
    }
}