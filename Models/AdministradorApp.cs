using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_Escuela.Models;

public class AdministradorApp
{
    public List<Profesor> Profesores { get; set; }
    public List<Estudiante> Estudiantes { get; set; }

    // constructor
    public AdministradorApp()
    {
        Profesores = new List<Profesor>();
        Estudiantes = new List<Estudiante>();
    }

    // Metodos

    // AgregarProfesor

    public void AgregarProfesor(Profesor p)
    {
        Profesores.Add(p);
    }

    // AgregarEstudiante
    public void AgregarEstudiante(Estudiante e)
    {
        Estudiantes.Add(e);
    }

    // Mostrar Estudiantes
    public void MostrarEstudiantes()
    {
        foreach (Estudiante e in Estudiantes)
        {
            e.MostrarDetalles();
        }
    }

    // Mostrar Profesores
    public void MostrarProfesores()
    {
        foreach (Profesor p in Profesores)
        {
            p.MostrarDetalles();
        }
    }

    // mostrar estudiantes con un promedio de calificaciones superiora 8.5
    public void MostrarPromedioSuperior()
    {
        foreach (Estudiante e in Estudiantes)
        {
            double promedio = e.CalcularPromedio();
            if (promedio > 8.5)
            {   
                Console.WriteLine(" ");
                e.MostrarDetalles();
            }
        }
    }

}
