using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1.entidades
{
    class venta
    {

        private int identificador_producto;
        private string nom_producto;
        private string descripcion;
        private double precio;
        private int cantidad;

        public int Identificador_producto { get => identificador_producto; set => identificador_producto = value; }
        public string Nom_producto { get => nom_producto; set => nom_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public venta(int identificador_producto, string nom_producto, string descripcion, double precio, int cantidad)
        {
            this.Identificador_producto = identificador_producto;
            this.Nom_producto = nom_producto;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }


    }
}
