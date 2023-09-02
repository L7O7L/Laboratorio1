using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Grifo
    {

        public List<Usuarios> usuarios;

        public void MostrarUsuarios()
        {

            foreach (var usuario in usuarios)
            {

                usuario.MostrarInformacion();

            }

        }

    }
}
