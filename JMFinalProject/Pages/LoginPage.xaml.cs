namespace JMFinalProject.Pages;

using JMFinalProject.Models;
using JMFinalProject.Pages;

public partial class LoginPage : ContentPage
{
    private Users user = new Users();
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btnsignin_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(entryEmail.Text) || string.IsNullOrEmpty(entryPassword.Text))
        {
            await DisplayAlert("Login", "Please enter your credentials!", "Got it");
        }
        else
        {
            progressLoading.IsVisible = true;
            var a = await user.UserLogin(entryEmail.Text, entryPassword.Text);
            if (a)
            {
                await DisplayAlert("Login", "Access granted!", "Got it");
                Application.Current!.MainPage = new AppShell();
                progressLoading.IsVisible = false;
                return;
            }
            await DisplayAlert("Login", "Access denied!", "Got it");
            progressLoading.IsVisible = false;
        }
    }
}