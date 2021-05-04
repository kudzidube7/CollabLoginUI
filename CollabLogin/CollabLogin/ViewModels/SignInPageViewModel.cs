using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollabLogin.ViewModels
{
    public class SignInPageViewModel : ViewModelBase
    {
        public DelegateCommand BackCommand { get; set; }
        public SignInPageViewModel(INavigationService _navigationService) : base(_navigationService)
        {
            BackCommand = new DelegateCommand(OnBackCommand);
        }

        private async void OnBackCommand()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
