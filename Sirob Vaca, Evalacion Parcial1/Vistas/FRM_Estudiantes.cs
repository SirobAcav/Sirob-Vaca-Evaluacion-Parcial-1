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
    public partial class FRM_Estudiantes : Form
    {
        public FRM_Estudiantes()
        {
            InitializeComponent();
        }
        EstudianteController ctrl = new EstudianteController();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var controller = new EstudianteController();
            controller.Agregar(txtNombre.Text.Trim(), txtCorreo.Text.Trim());
            MessageBox.Show("Estudiante guardado");
            CargarLista();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem != null)
            {
                int id = int.Parse(lstEstudiantes.SelectedItem.ToString().Split('-')[0].Trim());
                var controller = new EstudianteController();
                controller.Eliminar(id);
                MessageBox.Show("Estudiante eliminado");
                CargarLista();
            }
        }
        private void CargarLista()
        {
            var controller = new EstudianteController();
            lstEstudiantes.Items.Clear();
            foreach (var est in controller.Listar())
                lstEstudiantes.Items.Add($"{est.EstudianteId} - {est.Nombre} - {est.Correo}");
        }
    }
}
