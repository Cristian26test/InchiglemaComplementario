using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InchiglemaComplementario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "1";
            string clave = "uisrael2023";
            if (txtUsuario.Text == usuario && txtClave.Text == clave)
            {
                Navigation.PushAsync(new principal());
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o clave incorrecta", "Ok");
            }
        }

    }
}

