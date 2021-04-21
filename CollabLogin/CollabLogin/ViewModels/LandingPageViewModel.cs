using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollabLogin.ViewModels
{
    public class LandingPageViewModel : ViewModelBase
    {
        public DelegateCommand SelectSignInCommand { get; set; }
        public LandingPageViewModel(INavigationService _navigationService):base(_navigationService)
        {
            SelectSignInCommand = new DelegateCommand(OnSelectSignInCommand);
        }

        private void OnSelectSignInCommand()
        {
            Console.WriteLine("works......");
        }

    }
}
