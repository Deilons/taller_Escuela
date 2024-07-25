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

    public void MostrarPromedioSuperior()
    {
        var estudiantesConPromedioSuperior = Estudiantes
            .Where(x => x.CalcularPromedio() > 8.5)
            .Select(x => x)
            .ToList();
        Console.WriteLine("Estudiantes con promedio superior a 8.5:");
        foreach (var e in estudiantesConPromedioSuperior)
        {
            Console.WriteLine(e);
        }
    }

    public void ObtenerProfesoresConMasCursos()
    {
        var profesoresConMasCursos = Profesores
            .GroupBy(x => x)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToList();
        Console.WriteLine("Profesores con más de un curso:");
        foreach (var p in profesoresConMasCursos)
        {
            Console.WriteLine(p);
        }
    }

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

    public void ObtenerSueldos()
    {
        double sueldos = Profesores.Sum(x => x.Sueldo);
        Console.WriteLine($"Sueldos totales: {sueldos}");
    }

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
    
    public void AcudienteEsMaria()
    {
        foreach (Estudiante e in Estudiantes)
        {
            if (e.NombreAcudiente.Contains("Maria"))
            {
                Console.WriteLine($@"
                Nombre: {e.Nombre}
                Apellidos: {e.Apellidos}
                Nombre Acudiente: {e.NombreAcudiente}
                ");
            }
        }
    }
    public void ListaSalariosDescencientes()
    {
        foreach (Profesor p in Profesores.OrderBy(x => x.Sueldo))
        {
            Console.WriteLine($@"
            Nombre: {p.Nombre}
            Apellidos: {p.Apellidos}
            Sueldo: {p.Sueldo}
            ");
        }
    }

    public void PromedioEdades()
    {
        double promedio = Estudiantes.Average(x => x.CalcularEdad());
        Console.WriteLine($"Promedio de edades: {promedio}");
    }

    public void ProfesoresMatematicas()
    {
        foreach (Profesor p in Profesores)
        {
            if (p.Cursos.Contains("Matemáticas"))
            {
                Console.WriteLine($@"
                Nombre: {p.Nombre}
                Apellidos: {p.Apellidos}
                Cursos: {p.Cursos}
                ");
            }
        }
    }

    public void CursosConMasDeTresCalificaciones()
    {
        var cursosConMasDeTresCalificaciones = Estudiantes
            .SelectMany(x => x.CursoActual)
            .GroupBy(x => x)
            .Where(x => x.Count() > 3)
            .Select(x => x.Key)
            .ToList();
        Console.WriteLine("Cursos con más de tres calificaciones:");
        foreach (var c in cursosConMasDeTresCalificaciones)
        {
            Console.WriteLine(c);
        }
    }
    public void antiguedadPromedio()
    {
        double promedio = Profesores.Average(x => x.CalcularAntiguedad());
        Console.WriteLine($"Promedio de antiguedad: {promedio}");
    }

}
