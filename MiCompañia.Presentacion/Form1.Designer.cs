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
            Button button2;
            Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Button button3;
            Button button4;
            panel1 = new Panel();
            panel3 = new Panel();
            panelBarraTitulo = new Panel();
            titulo = new Label();
            pictureBox1 = new PictureBox();
            btnMiminizar = new PictureBox();
            btnMaximizar = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMiminizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.World, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 312);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(230, 45);
            button2.TabIndex = 1;
            button2.Text = "Generar";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.World, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 250);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(230, 45);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "Generar Convocatoria";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelBarraTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Verdana", 9.75F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 738);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseHover += pictureBox1_MouseHover;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(86, 5, 141);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 40);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 698);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.AutoScroll = true;
            panelBarraTitulo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBarraTitulo.BackColor = Color.Black;
            panelBarraTitulo.Controls.Add(titulo);
            panelBarraTitulo.Controls.Add(pictureBox1);
            panelBarraTitulo.Controls.Add(btnMiminizar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.RightToLeft = RightToLeft.Yes;
            panelBarraTitulo.Size = new Size(1373, 40);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.Paint += panelBarraTitulo_Paint;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(12, 12);
            titulo.Name = "titulo";
            titulo.Size = new Size(314, 16);
            titulo.TabIndex = 3;
            titulo.Text = "Documentos para Participación Ciudadana";
            titulo.Click += titulo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.maximize3;
            pictureBox1.Location = new Point(1314, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // btnMiminizar
            // 
            btnMiminizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMiminizar.BackColor = Color.Transparent;
            btnMiminizar.BackgroundImageLayout = ImageLayout.Center;
            btnMiminizar.Cursor = Cursors.Hand;
            btnMiminizar.Image = (Image)resources.GetObject("btnMiminizar.Image");
            btnMiminizar.Location = new Point(1283, 9);
            btnMiminizar.Name = "btnMiminizar";
            btnMiminizar.Size = new Size(16, 16);
            btnMiminizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMiminizar.TabIndex = 1;
            btnMiminizar.TabStop = false;
            btnMiminizar.Click += btnMiminizar_Click;
            btnMiminizar.MouseHover += pictureBox1_MouseHover;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.BackgroundImageLayout = ImageLayout.Center;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1345, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(16, 16);
            btnMaximizar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMaximizar.TabIndex = 0;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += pictureBox1_Click;
            btnMaximizar.MouseHover += btnMaximizar_MouseHover;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.World, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 357);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(230, 45);
            button3.TabIndex = 2;
            button3.Text = "Abrir Documento";
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.World, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 402);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(230, 45);
            button4.TabIndex = 3;
            button4.Text = "Cerrar Documento";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
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
            panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMiminizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelBarraTitulo;
        private Panel panel3;
        private PictureBox btnMiminizar;
        private Button button1;
        private Button button2;
        private PictureBox btnMaximizar;
        private PictureBox pictureBox1;
        private Label titulo;
    }
}