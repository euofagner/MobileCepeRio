namespace AppCepeRio.Views;

public partial class ProfileView : ContentPage
{
	public ProfileView()
	{
		InitializeComponent();
	}

    private async void LogoutBtn_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//LoginView");
    }
}