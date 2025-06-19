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
    public partial class FRM_Cursos : Form
    {
        public FRM_Cursos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var controller = new CursoController();
            controller.Agregar(txtCurso.Text.Trim(), int.Parse(txtCreditos.Text.Trim()));
            MessageBox.Show("Curso guardado");
            CargarLista();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCursos.SelectedItem != null)
            {
                string seleccionado = lstCursos.SelectedItem.ToString();
                int id = int.Parse(seleccionado.Split('-')[0].Trim());
                var controller = new CursoController();
                controller.Eliminar(id);
                MessageBox.Show("Curso eliminado");
                CargarLista();
            }
        }
        private void CargarLista()
        {
            var controller = new CursoController();
            lstCursos.Items.Clear();
            foreach (var curso in controller.Listar())
                lstCursos.Items.Add($"{curso.CursoId} - {curso.NombreCurso} - {curso.Creditos} créditos");
        }
    }
}
