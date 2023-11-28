using CVDinámico.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CVDinámico.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}