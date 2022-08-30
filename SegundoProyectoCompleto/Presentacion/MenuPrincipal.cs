using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SegundoProyectoCompleto.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEstaciones_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            ControlPersona control = new ControlPersona();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
            
           
        }
    }
}
