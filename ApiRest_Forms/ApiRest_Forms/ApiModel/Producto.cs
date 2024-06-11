using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRest_Forms.ApiModel
{
    public class Producto
    {
        public string Id { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }
}
