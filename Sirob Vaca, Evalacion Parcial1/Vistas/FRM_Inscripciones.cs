using Sirob_Vaca__Evalacion_Parcial1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirob_Vaca__Evalacion_Parcial1.Vistas
{
    public partial class FRM_Inscripciones : Form
    {
        public FRM_Inscripciones()
        {
            InitializeComponent();
        }

        private void FRM_Inscripciones_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarCursos();
            CargarInscripciones();
        }
        private void CargarEstudiantes()
        {
            var ctrl = new EstudianteController();
            cmbEstudiantes.DataSource = ctrl.Listar();
            cmbEstudiantes.DisplayMember = "Nombre";
            cmbEstudiantes.ValueMember = "EstudianteId";
        }
        private void CargarCursos()
        {
            var ctrl = new CursoController();
            cmbCursos.DataSource = ctrl.Listar();
            cmbCursos.DisplayMember = "NombreCurso";
            cmbCursos.ValueMember = "CursoId";
        }
        private void CargarInscripciones()
        {
            var ctrl = new InscripcionController();
            lstInscripciones.Items.Clear();
            foreach (var insc in ctrl.ListarDetalleInscripciones())
                lstInscripciones.Items.Add(insc);
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int idEst = (int)cmbEstudiantes.SelectedValue;
            int idCur = (int)cmbCursos.SelectedValue;
            new InscripcionController().Inscribir(idEst, idCur);
            MessageBox.Show("Inscripción realizada");
            CargarInscripciones();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstInscripciones.SelectedItem is InscripcionDetalle seleccion)
            {
                var ctrl = new InscripcionController();
                ctrl.Eliminar(seleccion.InscripcionId);
                MessageBox.Show("Inscripción eliminada");
                CargarInscripciones();
            }
        }
        public class InscripcionDetalle
        {
            public int InscripcionId { get; set; }
            public string Texto { get; set; }

            public override string ToString()
            {
                return Texto;
            }
        }
    }
}
