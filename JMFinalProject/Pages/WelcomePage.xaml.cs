namespace JMFinalProject.Pages;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void btnlogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.LoginPage());
    }
    private async void btnGetStarted_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}