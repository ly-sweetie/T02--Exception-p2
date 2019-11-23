using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar
            var Estudiantes = new List<Estudiante>();

            var agregar = true;
            //Declar variables
            bool Result;
            var E = new Estudiante();
            int M = E.Matricula;

            //Realizar un while
            while (agregar)
            {
                //Ponemos el try
                try
                {
                    //Ingresar datos del usuario
                    Console.WriteLine("Ingresa tu nombre:");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa tu Carrera:");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingresa tu semestre actual:");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu Matricula:");
                    //hacemos un tryparse
                    Result = int.TryParse(Console.ReadLine(), out M);
                    //hacemos por si el usuario ingresa un dato que no es correcto y le pedimos que lo ingrese
                    if (Result == false)
                    {
                        Console.WriteLine("Ingrese un numero");
                        Console.WriteLine("");
                        Result = int.TryParse(Console.ReadLine(), out M);

                    }

                    Estudiantes.Add(E);
                    //le preguntamos al usuario si desea agregar otro alumno
                    Console.WriteLine("Desea agrear otro usuario:\nY/N");
                    if (Console.ReadLine() != "Y")
                    {
                        agregar = false;
                    }
                }
                //Ponemos el catch
                catch (Exception)
                {

                }

                //El trycatch señala un bloque de instrucciones a intentar y
                //especifica una respuesta si se produce una excepción
            }
        }
    }
}
