namespace Android.TestOnly.Bug.Reproduce;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
