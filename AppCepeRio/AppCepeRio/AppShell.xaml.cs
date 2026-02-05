using AppCepeRio.Views;

namespace AppCepeRio
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(FacialRecognition), typeof(FacialRecognition));
        }
    }
}
