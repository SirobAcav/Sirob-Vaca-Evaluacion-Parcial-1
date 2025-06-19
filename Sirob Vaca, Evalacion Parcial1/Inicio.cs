using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirob_Vaca__Evalacion_Parcial1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            var FRM_Estudiantes = new Vistas.FRM_Estudiantes();
            this.Hide();
            FRM_Estudiantes.ShowDialog();
            this.Show();
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            var FRM_Cursos = new Vistas.FRM_Cursos();
            this.Hide();
            FRM_Cursos.ShowDialog();
            this.Show();
        }
        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            var FRM_Inscripciones = new Vistas.FRM_Inscripciones();
            this.Hide();
            FRM_Inscripciones.ShowDialog();
            this.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
