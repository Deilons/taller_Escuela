using taller_Escuela.Models;

var administradorApp = new AdministradorApp();

administradorApp.AgregarProfesor(new Profesor()
{   
    Id = 1,
    Nombre = "Juan",
    Apellidos = "Perez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "j@j.com",
    Telefono = "123456789",
    Asignatura = "Programacion",
    Sueldo = 5000,
    FechaContrato = new DateTime(2021, 11, 11),
    Cursos = new List<string> { "Programacion", "Ingles" }
});

administradorApp.MostrarProfesores();


administradorApp.Profesores[0].ObtenerSueldo();

Console.WriteLine("-----------------------");

administradorApp.AgregarEstudiante(new Estudiante()
{
    Id = 1,
    Nombre = "Maria",
    Apellidos = "Gonzalez",
    TipoDocumento = "DNI",
    NroDocumento = "12345678",
    Email = "m@m.com",
    Telefono = "123456789",
    NombreAcudiente = "Pedro",
    CursoActual = "Programacion",
    Calificaciones = new List<double> { 8.5, 9.0, 7.5 }
});

administradorApp.MostrarEstudiantes();

Console.WriteLine("-----------------------");


administradorApp.Estudiantes[0].CalcularPromedio();