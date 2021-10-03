using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace App6.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        Command _goToViewStartCommand;
        private string _usuario;
        private string _contrasena;
        private bool isError;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
        }

        public string Usuario
        {
            get => _usuario;
            set
            {                
                _usuario = value;
                OnPropertyChanged();
            }
        }

        public string Contrasena
        {
            get => _contrasena;
            set
            {                
                _contrasena = value;
                OnPropertyChanged();
            }
        }

        public Command GoToViewStartCommand
        {
            get => _goToViewStartCommand ?? (_goToViewStartCommand = new Command(GoToViewAction));
        }

        public bool IsError
        {
            get => isError;
            set
            {
                isError = value;
                OnPropertyChanged();
            }
        }

        private void GoToViewAction()
        {     
            IsError = !(string.Equals(Usuario, "hola") && string.Equals(Contrasena, "1234"));
            
            if(!IsError)
            {                
                Usuario = string.Empty;
                Contrasena = string.Empty;
                Navigation.PushAsync(new NavigationPage(new PageStart()));
            }
            
        }
    }
}
