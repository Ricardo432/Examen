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
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Materia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.database1DataSet.Materia);

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
