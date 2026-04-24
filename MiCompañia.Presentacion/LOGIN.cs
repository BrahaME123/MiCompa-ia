using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MiCompañia.Soporte.cache;
using System.Windows.Forms;
using MiCompañia.Dominio;

namespace MiCompañia.Presentacion
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Username " && txtUser.TextLength>2   ) 
            {
                if (txtpass.Text != "Password")
                {

                    UserModel usuario = new UserModel();
                    var validLogin = usuario.LoginUser(txtUser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        MessageBox.Show("login");
                        MessageBox.Show("BIENVENIDO" + txtUser.Text);
                        Console.WriteLine("Funciona la chingadera");
                    }
                    else
                    {
                        MessageBox.Show("no login");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese su contraseña");
                    txtErrorPass.Visible = true     ;

                }

            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "Password";
            txtpass.UseSystemPasswordChar = false;
            txtUser.Text = "Username";
            txtErrorPass.Visible = false;
            this.Show();
        }
    }
}
