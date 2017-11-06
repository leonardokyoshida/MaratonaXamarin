using System.Threading.Tasks;

namespace MaratonaXamarin.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _descricao;
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                SetProperty(ref _descricao, value);
            }
        }

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                SetProperty(ref _nome, value);
            }
        }

        public MainViewModel()
        {
            Descricao = "Olá mundo, estou aqui";

            Task.Delay(3000).ContinueWith(t =>
            {
                Descricao = "Mudou o texto";
            });
        }

        
    }
}
