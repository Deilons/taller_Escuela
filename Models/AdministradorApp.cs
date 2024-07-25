using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_Escuela.Models;

    public class AdministradorApp
    {
        public List<Profesor> Profesores { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        public AdministradorApp()
        {
            Profesores = new List<Profesor>();
            Estudiantes = new List<Estudiante>();
        }

        public void AgregarProfesor(Profesor p)
        {
            Profesores.Add(p);
        }

        public void AgregarEstudiante(Estudiante e)
        {
            Estudiantes.Add(e);
        }

        public void MostrarEstudiantes()
        {
            foreach (Estudiante e in Estudiantes)
            {
                e.MostrarDetalles();
            }
        }

        public void MostrarProfesores()
        {
            foreach (Profesor p in Profesores)
            {
                p.MostrarDetalles();
            }
        }
    }
