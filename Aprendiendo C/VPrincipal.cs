using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreriab;


namespace Aprendiendo_C
{
    public partial class VPrincipal : Form
    {
        public VPrincipal()
        {
            InitializeComponent();
        }

        private void mantenimietosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void antiguedadDeSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM usuarios where num_usuario=" + Vlogin.Codigo;

            DataSet DS = Utileria.Ejecutar(cmd);

            lbluserlog.Text = DS.Tables[0].Rows[0]["NOMBRE"].ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
