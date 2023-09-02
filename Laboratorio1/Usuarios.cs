// See https://aka.ms/new-console-template for more information

namespace Laboratorio1
{
    public class Usuarios
    {

        public string Nombre { get; set; }
        public double Saldo { get; set; }

        public Usuarios(string nombre, double saldo)
        {
            this.Nombre = nombre;
            this.Saldo = saldo;
        }

        public virtual void MostrarInformacion()
        {

            Console.WriteLine(Nombre + " --> " + Saldo);

        }

    }

}
