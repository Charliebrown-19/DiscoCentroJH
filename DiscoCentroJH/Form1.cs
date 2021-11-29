using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Entity.Migrations;

namespace DiscoCentroJH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtlogin_Enter(object sender, EventArgs e)
        {
            if (txtlogin.Text == "Usuario") 
            {
                txtlogin.Text = "";
                txtlogin.ForeColor = Color.LightBlue;
            }
        }

        private void txtlogin_Leave(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                txtlogin.Text = "Usuario";
                txtlogin.ForeColor = Color.LightBlue;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightBlue;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.LightBlue;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtlogin.Text != "Username")
            {
                if (txtpass.Text !="Password")
                {
                   
                                   }
                else
                
                    Errormsg("Ingrese su contraseña");
                
            }
            else  Errormsg("Ingrese su usuario"); 

        }
        private void Errormsg(string msg)
        {
            lblerror.Text = msg;
            lblerror.Visible = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
