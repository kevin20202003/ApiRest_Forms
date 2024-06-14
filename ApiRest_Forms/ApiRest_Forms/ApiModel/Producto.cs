using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRest_Forms.ApiModel
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}
