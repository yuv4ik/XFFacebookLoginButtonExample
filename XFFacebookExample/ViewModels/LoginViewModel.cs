using System.Windows.Input;
using Xamarin.Forms;

namespace XFFacebookExample
{
    public class LoginViewModel
    {
        public ICommand OnFacebookLoginSuccessCmd { get; }
        public ICommand OnFacebookLoginErrorCmd { get; }
        public ICommand OnFacebookLoginCancelCmd { get; }

        public LoginViewModel()
        {
            OnFacebookLoginSuccessCmd = new Command<string>(
                (authToken) => DisplayAlert("Success", $"Authentication succeed: {authToken}"));

            OnFacebookLoginErrorCmd = new Command<string>(
                (err) => DisplayAlert("Error", $"Authentication failed: {err}"));
            
            OnFacebookLoginCancelCmd = new Command(
                () => DisplayAlert("Cancel", "Authentication cancelled by the user."));
        }

        void DisplayAlert(string title, string msg) =>
            (Application.Current as App).MainPage.DisplayAlert(title, msg, "OK");
    }
}
