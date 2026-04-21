namespace MiCompañia.Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panelBarraTitulo = new Panel();
            btnMiminizar = new PictureBox();
            btnMaximizar = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMiminizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelBarraTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 738);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1173, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 698);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 20);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 698);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(0, 70);
            button2.Name = "button2";
            button2.Size = new Size(197, 46);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(197, 46);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.Blue;
            panelBarraTitulo.Controls.Add(btnMiminizar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1373, 40);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.Paint += panelBarraTitulo_Paint;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btnMiminizar
            // 
            btnMiminizar.Image = Properties.Resources.criko;
            btnMiminizar.Location = new Point(1172, 3);
            btnMiminizar.Name = "btnMiminizar";
            btnMiminizar.Size = new Size(91, 37);
            btnMiminizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMiminizar.TabIndex = 1;
            btnMiminizar.TabStop = false;
            btnMiminizar.Click += btnMiminizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Image = Properties.Resources.criko;
            btnMaximizar.Location = new Point(1279, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(91, 37);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 0;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 738);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMiminizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelBarraTitulo;
        private Panel panel3;
        private Panel panel4;
        private PictureBox btnMaximizar;
        private PictureBox btnMiminizar;
        private Button button1;
        private Button button2;
    }
}