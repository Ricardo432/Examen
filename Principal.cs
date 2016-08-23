using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void tema_Click(object sender, EventArgs e)
        {
            //this.Close();
            Tema tema = new Tema();
            tema.Show();
        }

        private void reactivo_Click(object sender, EventArgs e)
        {
            //this.Close();
            Reactivo rea = new Reactivo();
            rea.Show();
        }

        private void estadistica_Click(object sender, EventArgs e)
        {
            
        }

        private void curso_Click(object sender, EventArgs e)
        {
            
        }

        private void materia_Click(object sender, EventArgs e)
        {
            //this.Close();
            Materia mat = new Materia();
            mat.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
