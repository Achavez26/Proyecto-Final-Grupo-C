using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Solucion_Estudiantes
    {
        public List<LEstudiantes> Estudiantes = new List<LEstudiantes>();

        public Solucion_Estudiantes()
        {
            Estudiantes = new List<LEstudiantes>();
        }

        // Metodo añadir 

        public void Añadir(LEstudiantes Estudiante)
        {
            Estudiantes.Add(Estudiante);
        }


        // Metodo Aprobar 
        public List<LEstudiantes> Aprobados()
        {
            List<LEstudiantes> aux = new List<LEstudiantes>();
            foreach (LEstudiantes estudiantes in Estudiantes)
            {
                if (estudiantes.Promedio >= 7)
                {
                    aux.Add(estudiantes);
                }
            }
            return aux;
        }

        // Metodo Supletorio
        public List<LEstudiantes> Supletorios()
        {
            List<LEstudiantes> aux = new List<LEstudiantes>();
            foreach (LEstudiantes estudiantes in Estudiantes)
            {
                if (estudiantes.Promedio < 7)
                {
                    aux.Add(estudiantes);
                }
            }
            return aux;
        }
        // Método para contar la cantidad de promedios ingresados que coinciden con un valor específico
        public int ContarPromediosIngresados(double valorPromedio)
        {
            int cantidad = 0;
            foreach (LEstudiantes estudiante in Estudiantes)
            {
                if (estudiante.Promedio == valorPromedio)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        // Método para buscar estudiantes por curso
        public List<LEstudiantes> BuscarPorCurso(string cursoBuscado)
        {
            List<LEstudiantes> estudiantesEncontrados = new List<LEstudiantes>();

            foreach (LEstudiantes estudiante in Estudiantes)
            {
                if (estudiante.Curso == cursoBuscado)
                {
                    estudiantesEncontrados.Add(estudiante);
                }
            }

            return estudiantesEncontrados;
        }
    }
}