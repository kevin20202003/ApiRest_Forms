using ApiRest_Forms.ApiModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApiRest_Forms
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private ObservableCollection<Model_Post> _posts;
        private Apis apis = new Apis();
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await _httpClient.GetStringAsync(apis.UrlPost);
            List<Model_Post> posts = JsonConvert.DeserializeObject<List<Model_Post>>(content);
            _posts = new ObservableCollection<Model_Post>(posts);
            MyListView.ItemsSource = posts;
            base.OnAppearing();
        }
    }
}
