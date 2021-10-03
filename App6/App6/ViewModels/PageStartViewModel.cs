using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PageStartViewModel : BaseViewModel
    {
        Command _goToLogin;
        Command _goToViewProfileCommand;

        public PageStartViewModel(INavigation navigation = null) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public Command GoToLoginCommand
        {
            get
            {
                if (_goToLogin == null)
                {
                    _goToLogin = new Command(GoToLoginAction);
                }
                return _goToLogin;
            }
        }

        private void GoToLoginAction()
        {
            Navigation.PopToRootAsync();
        }

        public Command GoToViewProfileCommand
        {
            get => _goToViewProfileCommand ?? (_goToViewProfileCommand = new Command(GoToViewAction));
        }

        private void GoToViewAction()
        {           
                Navigation.PushAsync(new NavigationPage(new PageProfile()));
        }
    }
}
