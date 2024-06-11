﻿using ApiRest_Forms.ApiModel;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ApiRest_Forms.Negocio
{
    public class NegocioProducto
    {
        static HttpClient client = new HttpClient();

        static async Task<Uri> CreateProductAsync(Producto producto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/product", producto);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        static async Task<Producto> GetProductoAsync(string Id)
        {
            Apis apis = new Apis();
            Producto producto = null;
            HttpResponseMessage response = await client.GetAsync(apis.ObtenerProducto+Id);
            if (response.IsSuccessStatusCode)
            {
                producto = await response.Content.ReadFromJsonAsync<Producto>();
            }

            return producto;
        }

        static async Task<Producto> UpdateProductAsync(Producto producto)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{producto.Id}", producto);
            response.EnsureSuccessStatusCode();

            //Deserilize the update product from the response body.
            producto = await response.Content.ReadFromJsonAsync<Producto>();
            return producto;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string Id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/products/{Id}");
            return response.StatusCode;
        }
    }
}
