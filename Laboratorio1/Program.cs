using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Program program = new Program();

            program.Menu();

        }

        public void Menu()
        {

            Usuarios usuarios;
            List<Usuarios> list = new List<Usuarios>();
            Grifo grifo;

            while (true)
            {
                Console.WriteLine("1 --> Mostrar información de usuarios" +
                "\n2 --> Agregar cliente" +
                "\n3 --> Agregar Empleado" +
                "\n4 --> Salir");

                Console.WriteLine("Ingrese una opción");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (  opcion == 1)
                {
                    grifo = new Grifo();
                    grifo.usuarios = list;
                    grifo.MostrarUsuarios();
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadLine();
             

                }else if ( opcion == 2)
                {

                    Console.WriteLine("Ingrese el nombre del cliente: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el saldo del cliente: ");
                    double saldo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese los Litros Cargados del Cliente: ");
                    double litrosCargados = Convert.ToDouble(Console.ReadLine());
                    usuarios = new Cliente(nombre, saldo, litrosCargados);
                    list.Add(usuarios);


                }
                else if (opcion == 3)
                {

                    Console.WriteLine("Ingrese el nombre del cliente: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el saldo del cliente: ");
                    double saldo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el Sueldo del Cliente: ");
                    double sueldo = Convert.ToDouble(Console.ReadLine());
                    usuarios = new Empleado(nombre, saldo, sueldo);
                    list.Add(usuarios);


                }
                else if ( opcion == 4)
                {

                    Console.WriteLine("Gracias por su preferencia!!!");
                    break;

                }
                else
                {

                    Console.WriteLine("Esa opción no existe");

                }

            }

        }

    }
}
