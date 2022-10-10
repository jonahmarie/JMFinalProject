namespace JMFinalProject;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(Pages.DiaryPage), typeof(Pages.DiaryPage));
    }
}