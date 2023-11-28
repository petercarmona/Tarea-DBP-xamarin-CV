using CVDinámico.ViewModels;
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
        public DisplayData(VMDisplayData vmd)
        {
            InitializeComponent();
            BindingContext = new VMDisplayData(Navigation, vmd);
        }
    }
}