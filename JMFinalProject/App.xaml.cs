using Firebase.Database;

namespace JMFinalProject;

public partial class App : Application
{
    public static FirebaseClient client = new("https://myfirstrtdb-f6914-default-rtdb.asia-southeast1.firebasedatabase.app/");
    public static string email, key;
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Pages.WelcomePage());
    }
}