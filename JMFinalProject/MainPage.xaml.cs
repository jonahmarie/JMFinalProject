using JMFinalProject.Models;

namespace JMFinalProject;

public partial class MainPage : ContentPage
{
    Users users = new Users();
    public MainPage()
    {
        InitializeComponent();
    }

    private async void btnregister_Clicked(object sender, EventArgs e)
    {
        var result = await users.AddUser(txtfname.Text, txtlname.Text, txtmail.Text, txtpword.Text);
        if (result == true)

        {
            await DisplayAlert("Register", "You've successfully registered", "Got it");

        }
        else
        {
            await DisplayAlert("Register", "Either your email is already in the record or you may have lost your internet connection", "Got it");
        }
    }
    private async void btncancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}