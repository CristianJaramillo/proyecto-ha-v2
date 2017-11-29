using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2.Model
{
    public class Producto : AbstractaRegistro
    {
        public Producto()
        {
//            throw new System.NotImplementedException();
        }

        public Producto(int idProductos, string idResponsable, string Nombre, string Talla, string Precio, string Stock, string FechaIngreso, string HoraIngreso)
        {
            this.idProductos = idProductos;
            this.idResponsable = idResponsable;
            this.Nombre = Nombre;
            this.Talla = Talla;
            this.Precio = Precio;
            this.Stock = Stock;
            this.FechaIngreso = FechaIngreso;
            this.HoraIngreso = HoraIngreso;
        }

        public int idProductos { get; set; }

        public string Nombre { get; set; }

        public string Talla { get; set; }

        public string Precio { get; set; }

        public string Stock { get; set; }

        public string idResponsable { get; set; }

        public Responsable Responsable { get; set; }

        public string FechaIngreso { get; set; }

        public string HoraIngreso { get; set; }
    }
}