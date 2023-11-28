using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CVDinámico.ViewModels
{
    public class VMDisplayData:BaseViewModel
    {

        #region VARIABLES

        string _FirstName;
        string _LastName;
        string _BirthDay;
        string _Ocupation;
        string _Phone;
        string _Email;

        #endregion

        #region CONSTRUCTOR

        public VMDisplayData()
        {

        }
        public VMDisplayData(INavigation navigation)
        {
            Navigation = navigation;

        }
        public VMDisplayData(INavigation navigation, VMDisplayData viewModel)
        {
            Navigation = navigation;
            FirstName = viewModel.FirstName;
            LastName = viewModel.LastName;
            BirthDay = viewModel.BirthDay;
            Ocupation = viewModel.Ocupation;
            Phone = viewModel.Phone;
            Email = viewModel.Email;
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
        public string BirthDay
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

        public async Task AsynchProcess()
        {

        }

        public void SimpleProcess()
        {

        }

        #endregion

        #region COMMANDS

        public ICommand AsynchProcessCommand => new Command(async () => await AsynchProcess());
        public ICommand SimpleProcessCommand => new Command(SimpleProcess);

        #endregion
    }
}
