namespace Shop.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Shop.UIForms.Views;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "correosbasura2009@hotmail.com";
            this.Password = "gilsonbba13";
        }
    
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a Email", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a Password", "Accept");
                return;
            }

            if (!this.Email.Equals("correosbasura2009@hotmail.com") || !this.Password.Equals("gilsonbba13"))
            {
                await Application.Current.MainPage.DisplayAlert("Ok", "User or Password Incorrect", "Accept");
                return;
            }

            // await Application.Current.MainPage.DisplayAlert("Ok", "Viva", "Accept");



            MainViewModel.GetInstance().Products = new ProducsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
        }
    }

}
