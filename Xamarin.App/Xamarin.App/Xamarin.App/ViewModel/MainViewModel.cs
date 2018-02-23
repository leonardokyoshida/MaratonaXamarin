using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.App.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            this.SearchCommand = new Command(ExecuteSearchCommand, CanExecuteSearchCommand);
        }

        private bool CanExecuteSearchCommand(object arg)
        {
            return !String.IsNullOrWhiteSpace(_searchTerm);
        }

        async void ExecuteSearchCommand(object obj)
        {
            await Task.Delay(2000);

           await App.Current.MainPage.DisplayAlert("EstacioneAqui", $"Você pesquisou por: {_searchTerm}", "Ok");
        }

        private string _searchTerm;

        public string SeachTerm
        {
            get { return _searchTerm; }
            set
            {
                if (SetProperty(ref _searchTerm, value))
                    this.SearchCommand.ChangeCanExecute();
            }
        }

        public Command SearchCommand { get; }

    }
}
