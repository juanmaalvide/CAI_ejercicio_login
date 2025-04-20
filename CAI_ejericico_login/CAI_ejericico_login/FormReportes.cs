using CAI_ejericico_login.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_ejericico_login
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        Facultad uba = new Facultad();
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            int cantidadExamenes = obtenerExamenesPorAlumno(16198);

            MessageBox.Show("El alumno 16198 tiene rendido " + cantidadExamenes + " examenes.");
        }

        private int obtenerExamenesPorAlumno(int idAlumno)
        {

            Alumno alumno = buscarAlumno(idAlumno);
            return alumno.Examenes.Count;

        }

        private Alumno buscarAlumno(int codigo)
        {
            Alumno alumnoBuscado = null;
            List<Alumno> listadoAlumnos = uba.Alumnos;

            foreach (Alumno alumno in listadoAlumnos)
            {
                if (alumno.Codigo == 16198)
                {
                    alumnoBuscado = alumno;
                    break;
                }
            }

            return alumnoBuscado;
        }

        private void btnGenerar3_Click(object sender, EventArgs e)
        {

            var alumnosFiltrados = FiltrarAlumnosConMultiplesCarreras(uba.Alumnos);
            var alumno = ObtenerAlumnoConMasAprobadas(alumnosFiltrados);

            string nombreAlumno = alumno.Nombre;
            string nombreCarreras = String.Join("", alumno.Carreras);
            List<int> materiasAprobadas = ObtenerMateriasAprobadasPorAlumno(alumno);

        }

        public List<Alumno> FiltrarAlumnosConMultiplesCarreras(List<Alumno> alumnos)
        {
            return alumnos.Where(a => a.Carreras.Count > 1).ToList();
        }

        public List<int> ObtenerMateriasAprobadasPorAlumno(Alumno alumno)
        {
                        //Necesito obtener las materias aprobadas por alumno
            List<int> MateriasAprobadas = new List<int>();
            foreach (var Examen in alumno.Examenes)
            {           //recorro todos sus examenes 
                if (Examen.Nota >= 4)
                {
                        //si saco mas de 4 agrego el id de la materia que aprobo
                    MateriasAprobadas.Add(Examen.IdMateria);
                }
            }
                        //devuelvo los id de las materias aprobadas
            return MateriasAprobadas;
        }

        public Alumno ObtenerAlumnoConMasAprobadas(List<Alumno> alumnos)
        {
            return alumnos
                .OrderByDescending(a => ObtenerMateriasAprobadasPorAlumno(a).Count)
                .FirstOrDefault();

        }

    }


}
