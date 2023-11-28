using CVDinámico.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace CVDinámico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PantallaPrincipal : ContentPage
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private async void btniniciar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) || 
                string.IsNullOrWhiteSpace(apellidos.Text) || 
                string.IsNullOrWhiteSpace(ocupacion.Text) || 
                string.IsNullOrWhiteSpace(telefono.Text) || 
                string.IsNullOrWhiteSpace(email.Text))
            {
                await DisplayAlert("Error", "Por favor, complete los campos obligatorios.", "Aceptar");
                return;
            }

            string _nombre = nombre.Text;
            string _apellidos = apellidos.Text;
            DateTime datepicked = nacimiento.Date;
            string _nacimiento = datepicked.ToString("dd/MM/yyyy");
            string _ocupacion = ocupacion.Text;
            string _telefono = telefono.Text;
            string _email = email.Text;

            Navigation.PushAsync(new DisplayData(_nombre, _apellidos, _nacimiento, _ocupacion, _telefono, _email));
        }
    }
}