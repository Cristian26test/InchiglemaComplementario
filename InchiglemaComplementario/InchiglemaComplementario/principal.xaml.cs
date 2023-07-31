using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InchiglemaComplementario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        private string URL = "http://192.168.20.42/ws_uisrael/post.php";
        private readonly HttpClient httpClient = new HttpClient();
        private ObservableCollection<Estudiante> post;
        private object listarEstudiantes;

        public Principal()
        {
            InitializeComponent();
            Obtener();
        }

        private void listarEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var objetoEstudiante = (Estudiante)e.SelectedItem;
            Navigation.PushAsync(new ActulizarEliminar(objetoEstudiante));

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertarEstudiante());
        }

        private async void Obtener() {

            var contenido = await httpClient.GetStringAsync(URL);
       

         
        }
    }
}