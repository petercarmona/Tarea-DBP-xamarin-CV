using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CVDinámico.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayData : ContentPage
    {
        public DisplayData(string nombre, string apellidos, string nacimiento, string ocupacion, string telefono, string email)
        {
            InitializeComponent();

            l_nombre.Text = $"Nombre: {nombre}";
            l_apellidos.Text = $"Apellidos: {apellidos}";
            l_nacimiento.Text = $"Nacimiento: {nacimiento}";
            l_ocupacion.Text = $"Ocupacion: {ocupacion}";
            l_telefono.Text = $"Telefono: {telefono}";
            l_email.Text = $"Email: {email}";
        }

        private void Btnrestart_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}