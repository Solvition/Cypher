using Solvition.Cypher.ViewModel.ViewModels;

namespace Solvition.Cypher.ViewModel.Test.ViewModels
{
    internal class FakeViewModel : ViewModelBase
    {
        private int _intProperty = 0;

        public int IntProperty
        {
            get { return _intProperty; }
            set { _intProperty = value; RaisePropertyChanged(); }
        }

        public void RaisePropertyByName(string propertyName)
        {
            RaisePropertyChanged(propertyName);
        }
    }
}
