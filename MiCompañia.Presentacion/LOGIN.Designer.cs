namespace MiCompañia.Presentacion
{
    partial class LOGIN
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
            label1 = new Label();
            txtUser = new TextBox();
            txtpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtErrorPass = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(13, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Verdana", 20F);
            txtUser.Location = new Point(114, 147);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(744, 40);
            txtUser.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Verdana", 20F);
            txtpass.Location = new Point(114, 239);
            txtpass.Margin = new Padding(4, 3, 4, 3);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(744, 40);
            txtpass.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(86, 5, 141);
            button1.Font = new Font("Verdana", 20F);
            button1.Location = new Point(431, 435);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(285, 50);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(86, 5, 141);
            button2.Font = new Font("Verdana", 20F);
            button2.Location = new Point(724, 435);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(285, 50);
            button2.TabIndex = 5;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtErrorPass
            // 
            txtErrorPass.AutoSize = true;
            txtErrorPass.ForeColor = Color.Red;
            txtErrorPass.Location = new Point(114, 109);
            txtErrorPass.Name = "txtErrorPass";
            txtErrorPass.Size = new Size(132, 12);
            txtErrorPass.TabIndex = 6;
            txtErrorPass.Text = "Contraseña Incorrecta.";
            txtErrorPass.Visible = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1261, 680);
            Controls.Add(txtErrorPass);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.World);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LOGIN";
            Opacity = 0.85D;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private TextBox txtpass;
        private Button button1;
        private Button button2;
        private Label txtErrorPass;
    }
}