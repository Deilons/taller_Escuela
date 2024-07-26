using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

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
    //agregar un profesor nuevo
    public void AgregarProfesorNuevo()
    {
        Console.Clear();

        bool datosValidos = false;
        while (!datosValidos)
        {
            Console.WriteLine("Ingrese el ID del profesor (número entero):");
            bool idValido = int.TryParse(Console.ReadLine(), out int id);
            if (!idValido)
            {
                Console.WriteLine("El ID debe ser un número entero. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el nombre del profesor (texto):");
            string nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese los apellidos del profesor (texto):");
            string apellidos = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(apellidos))
            {
                Console.WriteLine("Los apellidos no pueden estar vacíos. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el tipo de documento del profesor (texto):");
            string tipoDocumento = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tipoDocumento))
            {
                Console.WriteLine("El tipo de documento no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el número de documento del profesor (texto):");
            string nroDocumento = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nroDocumento))
            {
                Console.WriteLine("El número de documento no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el email del profesor (texto):");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("El email no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el teléfono del profesor (número entero):");
            bool telefonoValido = int.TryParse(Console.ReadLine(), out int telefono);
            if (!telefonoValido)
            {
                Console.WriteLine("El teléfono debe ser un número entero. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el sueldo del profesor (número decimal):");
            bool sueldoValido = double.TryParse(Console.ReadLine(), out double sueldo);
            if (!sueldoValido)
            {
                Console.WriteLine("El sueldo debe ser un número decimal. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese la fecha de contrato del profesor (formato: dd/MM/yyyy):");
            bool fechaContratoValida = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaContrato);
            if (!fechaContratoValida)
            {
                Console.WriteLine("La fecha de contrato debe tener el formato dd/MM/yyyy. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese los cursos del profesor (separados por coma):");
            string cursosStr = Console.ReadLine();
            List<string> cursos = cursosStr.Split(',').ToList();

            bool todosLosCursosSonTexto = cursos.All(c => !string.IsNullOrWhiteSpace(c));
            if (!todosLosCursosSonTexto)
            {
                Console.WriteLine("Todos los cursos deben ser texto. Intente nuevamente.");
                continue;
            }
            Profesor nuevoProfesor = new Profesor
            {
                Id = id,
                Nombre = nombre,
                Apellidos = apellidos,
                TipoDocumento = tipoDocumento,
                NroDocumento = nroDocumento,
                Email = email,
                Telefono = telefono.ToString(),
                Sueldo = sueldo,
                FechaContrato = fechaContrato,
                Cursos = cursos
            };

            Console.WriteLine("Profesor agregado exitosamente.");

            Console.WriteLine(" ");

            AgregarProfesor(nuevoProfesor);

            datosValidos = true;
            
        }
        
    }
    public void AgregarEstudianteNuevo()
    {
        Console.Clear();

        bool datosValidos = false;
        while (!datosValidos)
        {
            Console.WriteLine("Ingrese el ID del estudiante (número entero):");
            bool idValido = int.TryParse(Console.ReadLine(), out int id);
            if (!idValido)
            {
                Console.WriteLine("El ID debe ser un número entero. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el nombre del estudiante (texto):");
            string nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese los apellidos del estudiante (texto):");
            string apellidos = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(apellidos))
            {
                Console.WriteLine("Los apellidos no pueden estar vacíos. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el tipo de documento del estudiante (texto):");
            string tipoDocumento = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tipoDocumento))
            {
                Console.WriteLine("El tipo de documento no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el número de documento del estudiante (texto):");
            string nroDocumento = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nroDocumento))
            {
                Console.WriteLine("El número de documento no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el email del estudiante (texto):");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("El email no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el teléfono del estudiante (número entero):");
            bool telefonoValido = int.TryParse(Console.ReadLine(), out int telefono);
            if (!telefonoValido)
            {
                Console.WriteLine("El teléfono debe ser un número entero. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese la fecha de nacimiento del estudiante (formato: dd/MM/yyyy):");
            bool fechaNacimientoValida = DateOnly.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly fechaNacimiento);
            if (!fechaNacimientoValida)
            {
                Console.WriteLine("La fecha de nacimiento debe tener el formato dd/MM/yyyy. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese el curso actual del estudiante (texto):");
            string cursoActual = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cursoActual))
            {
                Console.WriteLine("El curso actual no puede estar vacío. Intente nuevamente.");
                continue;
            }

            Console.WriteLine("Ingrese las calificaciones del estudiante (separadas por coma):");
            string calificacionesStr = Console.ReadLine();
            List<string> calificaciones = calificacionesStr.Split(',').ToList();
            if (calificaciones.Count == 0)
            {
                Console.WriteLine("Las calificaciones no pueden estar vacías. Intente nuevamente.");
                continue;
            }

            Estudiante nuevoEstudiante = new Estudiante
            {
                Id = id,
                Nombre = nombre,
                Apellidos = apellidos,
                TipoDocumento = tipoDocumento,
                NroDocumento = nroDocumento,
                Email = email,
                Telefono = telefono.ToString(),
                FechaNacimiento = fechaNacimiento,
                CursoActual = cursoActual,
                Calificaciones = new List<double>(),
            };

            Console.WriteLine("Estudiante agregado exitosamente.");

            Console.WriteLine(" ");

            AgregarEstudiante(nuevoEstudiante);

            datosValidos = true;
        }
    }

    // Mostrar Profesores
    public void MostrarProfesores()
    {
        Console.Clear();

        foreach (Profesor p in Profesores)
        {
            p.MostrarDetalles();
        }
    }

    public void MostrarEstudiantes()
    {
        Console.Clear();
        foreach (Estudiante e in Estudiantes)
        {
            e.MostrarDetalles();
        }
    }

    public void MostrarPromedioSuperior()
    {
        Console.Clear();

        var estudiantesConPromedioSuperior = Estudiantes
            .Where(x => x.CalcularPromedio() > 8.5)
            .Select(x => x)
            .ToList();
        Console.WriteLine("Estudiantes con promedio superior a 8.5:");
        foreach (var e in estudiantesConPromedioSuperior)
        {
            Console.WriteLine($"Nombre: {e.Nombre}");
            Console.WriteLine($"Apellidos: {e.Apellidos}");
            Console.WriteLine($"Promedio: {e.CalcularPromedio()}");
            Console.WriteLine();
        }
    }

    public void ObtenerProfesoresConMasCursos()
    {
        Console.Clear();

        var profesoresConMasCursos = Profesores
            .Where(profesor => profesor.Cursos.Count > 1)
            .ToList();

        Console.WriteLine("Profesores con más de un curso:");
        foreach (var profesor in profesoresConMasCursos)
        {
            Console.WriteLine($"Nombre: {profesor.Nombre}");
            Console.WriteLine($"Apellidos: {profesor.Apellidos}");
            Console.WriteLine($"Cursos: {string.Join(", ", profesor.Cursos)}");
            Console.WriteLine();
        }
    }

    public void FiltrarEdadEstudiantes()
    {
        Console.Clear();

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
        Console.Clear();

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
        Console.Clear();

        double sueldos = Profesores.Sum(x => x.Sueldo);
        Console.WriteLine($"Sueldos totales: {sueldos}");
    }

    public void NotaMayorPorCurso()
    {
        Console.Clear();

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
        Console.Clear();
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
        Console.Clear();

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
            Console.WriteLine($@"
            " + c
            );
        }
    }

    public void AcudienteEsMaria()
    {
        Console.Clear();

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
        Console.Clear();

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
        Console.Clear();

        double promedio = Estudiantes.Average(x => x.CalcularEdad());
        Console.WriteLine($"Promedio de edades: {promedio}");
    }

    public void ProfesoresMatematicas()
    {
        Console.Clear();
        foreach (Profesor p in Profesores)
        {
            if (p.Cursos.Contains("Matematicas"))
            {
                Console.WriteLine($@"
                Nombre: {p.Nombre}
                Apellidos: {p.Apellidos}
                Cursos: {string.Join(", ", p.Cursos)}
                ");
            }
        }
    }

    public void CursosConMasDeTresCalificaciones()
    {
        Console.Clear();
        foreach (Estudiante e in Estudiantes)
        {
            if (e.Calificaciones.Count > 2)
            {
                Console.WriteLine($@"
                Nombre: {e.Nombre}
                Apellidos: {e.Apellidos}
                Cursos: {string.Join(", ", e.CursoActual)}
                ");
            }
        }
    }
    public void AntiguedadPromedio()
    {
        Console.Clear();

        double promedio = Profesores.Average(x => x.CalcularAntiguedad());
        Console.WriteLine($"Promedio de antiguedad: {promedio}");
    }

    public void InterfazVisual()
    {

        Console.WriteLine(
    @"
╔══════════════════════════════════════════════════╗
║                 MENU DE OPCIONES                 ║                   
║                    COLEGIO                       ║
║                                                  ║
║           1. Agregar Profesor                    ║
║           2. Agregar Estudiante                  ║
║           3. Mostrar Profesores                  ║
║           4. Mostrar Estudiantes                 ║
║           5. Mostrar Promedio                    ║
║           6. Mostrar Profesores con mas cursos   ║
║           7. Filtrar Estudiantes por Edad        ║
║           8. Estudiantes por Apellidos           ║
║           9. Obtener Sueldos                     ║
║          10. Nota Mayor por Cursos               ║
║          11. Profesores con más de 10 años       ║
║          12. Asignaturas Únicas                  ║
║          13. Acudiente es Maria                  ║
║          14. Lista de Salarios Descendientes     ║
║          15. Promedio de Edades                  ║
║          16. Profesores de Matemáticas           ║
║          17. Cursos con más de 3 Calificaciones  ║
║          18. Antigüedad Promedio                 ║
║          19. Salir                               ║
╚══════════════════════════════════════════════════╝
            Opción: "
    );




    }

}