using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Cliente : Usuarios
    {
        public double LitrosCargados { get; set; }

        public Cliente(string nombre, double saldo, double litrosCargados) : base(nombre, saldo)
        {
            this.LitrosCargados = litrosCargados;
            this.Nombre = nombre;
            this.Saldo = saldo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Nombre --> " + Nombre + "\n" +
                "Saldo --> " + Saldo +
                "\n" + "Litros Cargados --> " + LitrosCargados);
        }

    }
}
