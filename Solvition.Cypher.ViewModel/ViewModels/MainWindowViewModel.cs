namespace Solvition.Cypher.ViewModel.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private LibraryViewModel _libraryViewModel = new LibraryViewModel();
        public LibraryViewModel LibraryViewModel
        {
            get => _libraryViewModel;
            set { _libraryViewModel = value; RaisePropertyChanged(); }
        }
    }
}
