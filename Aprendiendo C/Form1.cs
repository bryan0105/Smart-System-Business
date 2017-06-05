using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Libreriab;
namespace Aprendiendo_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * from USUARIOS WHERE usuario='{0}' AND clave='{1}'", txtUsuario.Text.Trim(), txtContra.Text.Trim());

                DataSet ds = Utileria.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["clave"].ToString().Trim();

                if (cuenta == txtUsuario.Text.Trim() && contra == txtContra.Text.Trim())
                {
                    MessageBox.Show("Se ha iniciado sesión");

                }else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta!!!");
                }
                

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            txtContra.Text = "";
        }
    }
}
