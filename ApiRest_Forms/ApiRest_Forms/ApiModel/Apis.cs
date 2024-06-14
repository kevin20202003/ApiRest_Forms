using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRest_Forms.ApiModel
{
    public class Apis
    {
        public string UrlPost { get; set; }
        public string ObtenerProducto { get; set; }
        public string CrearProducto { get; set; }
        public string ActualizarProducto { get; set; }
        public string EliminarProducto { get; set; }
        public string HttpRequest { get; set; }
        public Apis()
        {
            this.UrlPost = "https://jsonplaceholder.typicode.com/posts";
            this.HttpRequest = "";
            this.ObtenerProducto = "http://192.168.70.164:45455/api/Productos?id=1";
            this.CrearProducto = "/api/products";
            this.ActualizarProducto = "/api/products/id";
            this.EliminarProducto = "/api/products/id";
        }
    }

}
