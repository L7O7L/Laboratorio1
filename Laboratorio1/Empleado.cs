using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Empleado: Usuarios
    {

        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            this.Sueldo = sueldo;
            this.Nombre = nombre;
            this.Saldo = saldo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Nombre --> " + Nombre + "\n" +
                "Saldo --> " +  Saldo + 
                "\n" + "Sueldo --> " + Sueldo);
        }

    }
}
