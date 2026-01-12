namespace AppCepeRio.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HomeView");
    }
}