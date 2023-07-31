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
	public partial class InsertarEstudiante : ContentPage
	{

        private string URL = "http://192.168.20.42/ws_uisrael/post.php";
        public InsertarEstudiante ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();

                var datos = new System.Collections.Specialized.NameValueCollection();
                datos.Add("codigo", txtCodigo.Text);
                datos.Add("nombre", txtNombre.Text);
                datos.Add("apellido", txtApellido.Text);
                datos.Add("curso", txtCurso.Text);
                datos.Add("paralelo", txtParalelo.Text);
                datos.Add("nota", txtNota.Text);

                cliente.UploadValues(URL, "POST", datos);


                Navigation.PushAsync(new Principal());
            }
            catch (Exception ex)
            {

            }

        }
    }
}