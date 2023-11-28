using CVDinámico.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CVDinámico.ViewModels
{
    public class VMPantallaPrincipal : BaseViewModel
    {
        #region VARIABLES

        string _FirstName;
        string _LastName;
        DateTime _BirthDay = DateTime.Now;
        string _Ocupation;
        string _Phone;
        string _Email;

        #endregion

        #region CONSTRUCTOR

        public VMPantallaPrincipal(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJECTS

        public string FirstName
        {
            get { return _FirstName; }
            set { SetValue(ref _FirstName, value); }
        }
        public string LastName
        {
            get { return _LastName; }
            set { SetValue(ref _LastName, value); }
        }
        public DateTime BirthDay
        {
            get { return _BirthDay; }
            set { SetValue(ref _BirthDay, value); }
        }
        public string Ocupation
        {
            get { return _Ocupation; }
            set { SetValue(ref _Ocupation, value); }
        }
        public string Phone
        {
            get { return _Phone; }
            set { SetValue(ref _Phone, value); }
        }
        public string Email
        {
            get { return _Email; }
            set { SetValue(ref _Email, value); }
        }

        #endregion

        #region PROCESSES

        public async Task SendCV()
        {
            var displayDataViewModel = new VMDisplayData(Navigation)
            {
                FirstName = FirstName,
                LastName = LastName,
                BirthDay = BirthDay.ToString("dd/MM/yyyy"),
                Ocupation = Ocupation,
                Phone = Phone,
                Email = Email
            };

            await Navigation.PushAsync(new DisplayData(displayDataViewModel));
        }


        public void SimpleProcess()
        {

        }

        #endregion

        #region COMMANDS

        public ICommand AsynchProcessCommand => new Command(async () => await SendCV());
        public ICommand SimpleProcessCommand => new Command(SimpleProcess);

        #endregion
    }
}

