using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {


            usuario usuario = new usuario();
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("Escriba su nombre para iniciar sesión"); //manuelZer0 usuario 
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Escriba su contraseña"); //1234
            usuario.Contra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(clsUsuario.acceso(usuario.Nombre, usuario.Contra));

            Venta venta = new Venta();
            if (clsUsuario.x == 1)
            {
                int y = 1;

                while (y == 1)
                {
                    Console.WriteLine("Escriba el id del producto");
                    int id_producto = Convert.ToInt32(Console.ReadLine());
                    string nombre_producto = Console.ReadLine();
                    string descripción = Console.ReadLine();
                    double precio = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }



}
    

