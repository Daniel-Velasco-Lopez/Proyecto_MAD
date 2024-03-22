using LibreriaMAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMAD
{
    public class Visualizador
    {
        public static void MostrarAulasDisponibles(List<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine($"Aula: {aula.Nombre}");
                // Aquí podremos mostrar más detalles sobre el aula 
            }
        }

        public static void MostrarRegistroIncidencia(RegistroIncidencia registro)
        {
            Console.WriteLine($"Folio: {registro.Folio.Numero}");
            Console.WriteLine($"Fecha: {registro.Fecha}");
            Console.WriteLine($"Nombre: {registro.Persona.Nombre}");
            Console.WriteLine($"Apellido: {registro.Persona.Apellido}");
            Console.WriteLine($"Carrera: {registro.Carrera.Nombre}"); // Accede a la propiedad Nombre de Carrera
            Console.WriteLine($"Grupo: {registro.Grupo.Nombre}"); // Accede a la propiedad Nombre de Grupo
            Console.WriteLine($"Aula: {registro.Aula.Nombre}"); // Accede a la propiedad Nombre de Aula
            Console.WriteLine($"Incidencia: {registro.Incidencia.Descripcion}"); // Accede a la propiedad Descripcion de Incidencia
                                                                                 // Mostrar más detalles del registro según sea necesario
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            int edad;
            bool edadValida = false;
            do
            {
                Console.Write("Edad: ");
                string edadStr = Console.ReadLine();
                if (int.TryParse(edadStr, out edad))
                {
                    edadValida = true;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Intente nuevamente.");
                }
            } while (!edadValida);

            Persona persona = new Persona(nombre, apellido, edad);

            Console.WriteLine("\nIngrese los datos de la carrera:");
            Console.Write("Nombre de la carrera: ");
            string nombreCarrera = Console.ReadLine();

            Carrera carrera = new Carrera(nombreCarrera);

            Console.WriteLine("\nIngrese los datos de la asignatura:");
            Console.Write("Nombre de la asignatura: ");
            string nombreAsignatura = Console.ReadLine();
            Console.Write("Código de la asignatura: ");
            string codigoAsignatura = Console.ReadLine();

            Asignatura asignatura = new Asignatura(nombreAsignatura, codigoAsignatura);

            Console.WriteLine("\nIngrese los datos del grupo:");
            Console.Write("Nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            Grupo grupo = new Grupo(nombreGrupo);

            Console.WriteLine("\nIngrese los datos del docente:");
            Console.Write("Nombre del docente: ");
            string nombreDocente = Console.ReadLine();

            Docente docente = new Docente(nombreDocente);

            Console.WriteLine("\nIngrese los datos de la incidencia:");
            Console.Write("Descripción de la incidencia: ");
            string descripcionIncidencia = Console.ReadLine();

            Incidencia incidencia = new Incidencia(descripcionIncidencia);

            Console.WriteLine("\nIngrese los datos del aula:");
            Console.Write("Nombre del aula: ");
            string nombreAula = Console.ReadLine();

            Aula aula = new Aula(nombreAula);

            RegistroIncidencia registro = new RegistroIncidencia(persona, carrera, asignatura, grupo, docente, incidencia, aula);

            Console.WriteLine("\nRegistro de Incidencia:");
            Visualizador.MostrarRegistroIncidencia(registro);

            // Esperar a que el usuario presione una tecla antes de salir
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

            // Commit realizado: Se han agregado validaciones para la edad del alumno y comentarios explicativos.
        }
    }
}