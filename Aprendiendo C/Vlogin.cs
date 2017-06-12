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
    public partial class Vlogin : Form
    {
        public Vlogin()
        {
            InitializeComponent();
        }
        public static String Codigo = "";
      public void button1_Click(object sender, EventArgs e)
        {
            try
            {       //Este Metodo le da formato y consulta la tabla usuario en la base de datos y sustituye con lo validado de login.
                string CMD = string.Format("Select * from USUARIOS WHERE cod_usuario='{0}' AND clave='{1}'", txtUsuario.Text.Trim(), txtContra.Text.Trim()); 
               
                // Este Data set ejecuta el comando de Sql de mas arriba y lo guarda en un DataSet
                DataSet ds = Utileria.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["num_usuario"].ToString().Trim();

                // Estos de aca abajo almacena en un DataSet el nombre del usuario y la clave.
               string cuenta = ds.Tables[0].Rows[0]["cod_usuario"].ToString().Trim();
               string contra = ds.Tables[0].Rows[0]["clave"].ToString().Trim();

                // Esto hace la validacion del usuario
                if (cuenta == txtUsuario.Text.Trim() && contra == txtContra.Text.Trim())
                {

                    VPrincipal VenPri = new VPrincipal();
                    this.Hide();
                    VenPri.Show();


                }else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta!!!");
                }
                

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;

        }

       /* private void txtContra_KeyPress(object sender,KeyPressEventArgs e)

       /* {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                this.button1_Click();

            }
        }*/

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            txtContra.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Vlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void txtContra_TabIndexChanged(object sender, EventArgs e)
        {
            txtContra.Text = "";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
