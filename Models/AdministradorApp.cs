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
            Edad: {e.CalcularEdad() + " años"}
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
    //estudiante con calificacion mas alta en su curso actual

    public void NotaMayorPorCurso()
    {
        Estudiante? estudianteEncontrado = null;

        Console.WriteLine("Ingrese el curso: ");
        string curso = Console.ReadLine();

        double notaMayor = double.MinValue;
        bool encontrado = false;

        if (string.IsNullOrWhiteSpace(curso))
        {
            Console.WriteLine("Por favor ingrese un curso, Quiere volver a intentar? s/n");
            string respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                NotaMayorPorCurso();
            }
            else
            {
                return;
            }

        }
        else
        {
            foreach (Estudiante e in Estudiantes)
            {
                double nota = e.Calificaciones.Max();
                if (curso == e.CursoActual && nota > notaMayor)
                {
                    notaMayor = nota;
                    encontrado = true;
                    estudianteEncontrado = e;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($@"
            Nombre: {estudianteEncontrado.Nombre}
            Apellidos: {estudianteEncontrado.Apellidos}
            Nota: {notaMayor}
            ");
            }
            else
            {
                Console.WriteLine("No se encontró ningún estudiante con la nota más alta en el curso especificado.");
            }
        }
    }
    //Filtrar los profesores que tienen más de 10 años de antigüedad en la institución.

    public void ProfesoresConMasDe10Años()
    {   
        foreach (Profesor p in Profesores)
        {
            if (p.CalcularAntiguedad() > 10)
            {
                Console.WriteLine($@"
                Nombre: {p.Nombre}
                Apellidos: {p.Apellidos}
                antiguedad: {p.CalcularAntiguedad() + " años"}
                ");

            }
        }
    }
    // Obtener la lista de asignaturas únicas que se imparten en la escuela.

    public void AsignaturasUnicas()
    {
        List<string> asignaturasUnicas = new List<string>();
        foreach (Profesor p in Profesores)
        {
            foreach (string c in p.Cursos)
            {
                if (!asignaturasUnicas.Contains(c))
                {
                    asignaturasUnicas.Add(c);
                }
            }
        }
        Console.WriteLine("Asignaturas unicas:");
        foreach (string c in asignaturasUnicas)
        {
            Console.WriteLine(c);
        }
    }


}
