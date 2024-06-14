using ApiRest_Forms.ApiModel;
using ApiRest_Forms.Negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiRest_Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mostrar : ContentPage
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private ObservableCollection<Producto> _productos;
        private NegocioProducto _productoNegocio;
        public Mostrar()
        {
            InitializeComponent();
            _productoNegocio = new NegocioProducto();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await CargarProductos();
        }

        private async Task CargarProductos()
        {
            var productos = await _productoNegocio.ObtenerTodosLosProductos();
            if (productos != null)
            {
                _productos = new ObservableCollection<Producto>(productos);
                ProductoListaview.ItemsSource = _productos;
            }
            else
            {
                await DisplayAlert("Error", "No se pudieron cargar los productos", "OK");
            }
        }
    }
}