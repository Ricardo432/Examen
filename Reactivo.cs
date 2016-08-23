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
    public partial class Reactivo : Form
    {
        public Reactivo()
        {
            InitializeComponent();
        }

        private void Reactivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.database1DataSet.Materia);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Pregunta' Puede moverla o quitarla según sea necesario.
            this.preguntaTableAdapter.Fill(this.database1DataSet.Pregunta);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Tema' Puede moverla o quitarla según sea necesario.
            this.temaTableAdapter.Fill(this.database1DataSet.Tema);
            // TODO: esta línea de código carga datos en la tabla 'examenDataSet.Pregunta' Puede moverla o quitarla según sea necesario.
            this.preguntaTableAdapter.Fill(this.database1DataSet.Pregunta);
            // TODO: esta línea de código carga datos en la tabla 'examenDataSet.Tema' Puede moverla o quitarla según sea necesario.
            this.temaTableAdapter.Fill(this.database1DataSet.Tema);
            // TODO: esta línea de código carga datos en la tabla 'examenDataSet.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.database1DataSet.Materia);

        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
