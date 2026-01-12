using AppCepeRio.ViewModels;

namespace AppCepeRio.Views;

public partial class OnBoarding : ContentPage
{
    public OnBoarding(OnBoardingViewModel onBoardingViewModel)
    {
        InitializeComponent();
        BindingContext = onBoardingViewModel;
        OnBoardingBtn.Text = "Próximo";
    }

    private async void OnBoardingBtn_Clicked(object sender, EventArgs e)
    {
        var items = OnBoardingCarousel.ItemsSource.Cast<object>().ToList();
        var currentItem = items.IndexOf(OnBoardingCarousel.CurrentItem);

        if (currentItem == items.Count - 1)
        {
            await Shell.Current.GoToAsync("//LoginView");
        }
        else
            OnBoardingCarousel.CurrentItem = items[currentItem + 1];
    }

    private void OnBoardingCarousel_PositionChanged(object sender, PositionChangedEventArgs e)
    {
        var items = OnBoardingCarousel.ItemsSource.Cast<object>().ToList();

        if (e.CurrentPosition == items.Count - 1)
        {
            OnBoardingBtn.Text = "Login";
        }
        else
            OnBoardingBtn.Text = "Próximo";
    }
}