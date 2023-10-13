namespace ArabaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            oyuncu = new PictureBox();
            bot_araba_2 = new PictureBox();
            bot_araba_1 = new PictureBox();
            yol2 = new PictureBox();
            yol1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)oyuncu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bot_araba_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bot_araba_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yol2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yol1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(oyuncu);
            panel1.Controls.Add(bot_araba_2);
            panel1.Controls.Add(bot_araba_1);
            panel1.Controls.Add(yol2);
            panel1.Controls.Add(yol1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 406);
            panel1.TabIndex = 0;
            // 
            // oyuncu
            // 
            oyuncu.Image = Properties.Resources.pembe_araba;
            oyuncu.Location = new Point(218, 275);
            oyuncu.Name = "oyuncu";
            oyuncu.Size = new Size(50, 100);
            oyuncu.SizeMode = PictureBoxSizeMode.AutoSize;
            oyuncu.TabIndex = 2;
            oyuncu.TabStop = false;
            // 
            // bot_araba_2
            // 
            bot_araba_2.Image = Properties.Resources.yesil_araba;
            bot_araba_2.Location = new Point(340, 62);
            bot_araba_2.Name = "bot_araba_2";
            bot_araba_2.Size = new Size(50, 101);
            bot_araba_2.SizeMode = PictureBoxSizeMode.AutoSize;
            bot_araba_2.TabIndex = 2;
            bot_araba_2.TabStop = false;
            bot_araba_2.Tag = "sagAraba";
            // 
            // bot_araba_1
            // 
            bot_araba_1.Image = Properties.Resources.ambulans;
            bot_araba_1.Location = new Point(100, 62);
            bot_araba_1.Name = "bot_araba_1";
            bot_araba_1.Size = new Size(50, 100);
            bot_araba_1.SizeMode = PictureBoxSizeMode.AutoSize;
            bot_araba_1.TabIndex = 2;
            bot_araba_1.TabStop = false;
            bot_araba_1.Tag = "solAraba";
            // 
            // yol2
            // 
            yol2.Image = Properties.Resources.yol;
            yol2.Location = new Point(0, -50);
            yol2.Name = "yol2";
            yol2.Size = new Size(475, 406);
            yol2.SizeMode = PictureBoxSizeMode.StretchImage;
            yol2.TabIndex = 1;
            yol2.TabStop = false;
            // 
            // yol1
            // 
            yol1.Image = Properties.Resources.yol;
            yol1.Location = new Point(0, -519);
            yol1.Name = "yol1";
            yol1.Size = new Size(475, 406);
            yol1.SizeMode = PictureBoxSizeMode.StretchImage;
            yol1.TabIndex = 0;
            yol1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Harlow Solid Italic", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(173, 420);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(158, 63);
            button1.TabIndex = 1;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(390, 417);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 2;
            label1.Text = "Puan: 0";
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 493);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Araba Oyunu";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)oyuncu).EndInit();
            ((System.ComponentModel.ISupportInitialize)bot_araba_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bot_araba_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)yol2).EndInit();
            ((System.ComponentModel.ISupportInitialize)yol1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox yol1;
        private PictureBox oyuncu;
        private PictureBox bot_araba_2;
        private PictureBox bot_araba_1;
        private PictureBox yol2;
        private System.Windows.Forms.Timer timer1;
    }
}