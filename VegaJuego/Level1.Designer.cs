﻿namespace VegaJuego
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            MovEnemigos = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelVida = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelEscudo = new Label();
            labelArma = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MovEnemigos
            // 
            MovEnemigos.Enabled = true;
            MovEnemigos.Tick += timer1_Tick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(664, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelVida
            // 
            labelVida.AutoSize = true;
            labelVida.BackColor = Color.Transparent;
            labelVida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVida.ForeColor = Color.Gold;
            labelVida.Location = new Point(713, 147);
            labelVida.Name = "labelVida";
            labelVida.Size = new Size(36, 17);
            labelVida.TabIndex = 1;
            labelVida.Text = "Vida\r\n";
            labelVida.Click += labelVida_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.escudo1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(664, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 33);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Arma1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(664, 209);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // labelEscudo
            // 
            labelEscudo.AutoSize = true;
            labelEscudo.BackColor = Color.Transparent;
            labelEscudo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEscudo.ForeColor = Color.Gold;
            labelEscudo.Location = new Point(713, 186);
            labelEscudo.Name = "labelEscudo";
            labelEscudo.Size = new Size(51, 17);
            labelEscudo.TabIndex = 4;
            labelEscudo.Text = "Escudo\r\n";
            // 
            // labelArma
            // 
            labelArma.AutoSize = true;
            labelArma.BackColor = Color.Transparent;
            labelArma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelArma.ForeColor = Color.Gold;
            labelArma.Location = new Point(713, 218);
            labelArma.Name = "labelArma";
            labelArma.Size = new Size(41, 17);
            labelArma.TabIndex = 5;
            labelArma.Text = "Arma";
            // 
            // Level1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoFinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 467);
            Controls.Add(labelArma);
            Controls.Add(labelEscudo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(labelVida);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Level1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VegaZelda";
            FormClosed += Level1_FormClosed;
            KeyPress += Level1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void labelVida_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer MovEnemigos;
        private PictureBox pictureBox1;
        private Label labelVida;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelEscudo;
        private Label labelArma;
    }
}