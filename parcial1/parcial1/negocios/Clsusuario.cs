using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1.negocios
{
    class Clsusuario
    {

        string user = "manuelZer0";
        int password = 1234;
        public int x;

//manuelZer0
//1234

        public string acceso(string nombre, int contra)
        {
            if (nombre == user && contra == password)
            {
                x = 1;

                return "Inicio de sesión correcto puedes continuar con el proceso de venta";

            }

            else
                x = 2;
            return "Nombre de usuario incorrecto";

        }

    }
}
