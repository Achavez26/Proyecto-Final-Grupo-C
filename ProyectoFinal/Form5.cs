using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form5 : Form
    {
        public Solucion_Estudiantes solucion_Estudiantes5 = new Solucion_Estudiantes();
        public Form5()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            double promedioBuscado = Convert.ToDouble(mtxtPromedio.Text);
            int cantidadEstudiantes = solucion_Estudiantes5.ContarPromediosIngresados(promedioBuscado);
            MessageBox.Show("En total hay " + cantidadEstudiantes + " estudiantes con el promedio " + promedioBuscado);
        }

        private void btnMostrarSe_Click(object sender, EventArgs e)
        {
            string cursoBuscado = txtBuscarSe.Text; // Suponiendo que tienes un TextBox llamado txtCurso donde el usuario ingresa el curso a buscar

            // Llamar al método BuscarPorCurso para obtener la lista de estudiantes del curso buscado
            List<LEstudiantes> estudiantesEncontrados = solucion_Estudiantes5.BuscarPorCurso(cursoBuscado);

            // Asignar la lista de estudiantes al DataGridView
            dvgBuscarSe.DataSource = estudiantesEncontrados;
        }
    }
}
