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
    //lista de profesores que enseñan más de un curso.

    public void ObtenerProfesoresConMasCursos()
    {
        foreach (Profesor p in Profesores)
        {
            if (p.Cursos.Count > 1)
            {
                Console.WriteLine(" ");
                p.MostrarDetalles();
            }
        }
    }
    //Filtrar la lista de estudiantes para obtener solo aquellos cuya edad sea mayor a 16 años.

    public void FiltrarEdadEstudiantes()
    {
        foreach (Estudiante e in Estudiantes)
        {
            if (e.CalcularEdad() > 16)
            {
                Console.WriteLine($@"
                Nombre: {e.Nombre}
                Apellidos: {e.Apellidos}
                Edad: {e.CalcularEdad()}
                ");
                
            }
        }
    }

    //lista de estudiantes ordenada por apellido en orden ascendente

    public void EstudiantesPorApellido()
    {

        foreach (Estudiante e in Estudiantes.OrderBy(x => x.Apellidos))
        {
            Console.WriteLine($@"
            Nombre: {e.Nombre}
            Apellidos: {e.Apellidos}
            Edad: {e.CalcularEdad()}
            ");
        }
    }

    //obtener sueldo total de todos los profesores
    public void ObtenerSueldos()
    {   
        double totalSueldos = 0;
        foreach (Profesor p in Profesores)
        {
            totalSueldos += p.Sueldo;
        }
        Console.WriteLine($"Sueldos totales: {totalSueldos}");
    }



}
