using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InchiglemaComplementario
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActulizarEliminar : ContentPage
	{

        private string URL = "http://192.168.20.42/ws_uisrael/post.php?codigo=";
        public ActulizarEliminar (Estudiante datos)
		{
			InitializeComponent ();

            txtCodigo.Text = datos.codigo.ToString();
            txtNombre.Text = datos.nombre.ToString();
            txtApellido.Text = datos.apellido.ToString();
            txtCurso.Text = datos.curso.ToString();
            txtParalelo.Text = datos.paralelo.ToString();
            txtNota.Text = datos.nota.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();

                var datos = new System.Collections.Specialized.NameValueCollection();
                datos.Add("nombre", txtNombre.Text);
                datos.Add("apellido", txtApellido.Text);
                datos.Add("curso", txtCurso.Text);
                datos.Add("paralelo", txtParalelo.Text);
                datos.Add("nota", txtNota.Text);

                var parametros = txtCodigo.Text + "&nombre=" + txtNombre.Text + "&apellido=" + txtApellido.Text + "&curso=" + txtCurso.Text + "&paralelo=" + txtParalelo.Text + "&nota=" + txtNota.Text;

                cliente.UploadValues(URL + parametros, "PUT", datos);





                Navigation.PushAsync(new Principal());
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Ok");
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();

                var datos = new System.Collections.Specialized.NameValueCollection();
                datos.Add("nombre", txtNombre.Text);

                cliente.UploadValues(URL + txtCodigo.Text, "DELETE", datos);



                Navigation.PushAsync(new Principal());
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Ok");
            }
        }
    }
}