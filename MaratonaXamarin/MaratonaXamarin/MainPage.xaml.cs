using MaratonaXamarin.ViewModels;
using Xamarin.Forms;

namespace MaratonaXamarin
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainViewModel();
		}
	}
}
