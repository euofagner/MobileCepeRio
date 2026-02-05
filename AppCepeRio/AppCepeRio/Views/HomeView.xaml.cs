using System.Threading.Tasks;

namespace AppCepeRio.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
	}

    private async void FacialTapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync($"{nameof(FacialRecognition)}");
    }
}