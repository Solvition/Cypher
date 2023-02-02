using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solvition.Cypher.ViewModel.ViewModels;

namespace Solvition.Cypher.ViewModel.Test.ViewModels
{
    [TestClass]
    public class MainWindowViewModelTests
    {
        [TestMethod]
        public void NewFileCommand_CreatesNewLibraryViewModel()
        {
            var mainWindowViewModel = new MainWindowViewModel();
            var initialLibraryViewModel = mainWindowViewModel.LibraryViewModel;

            mainWindowViewModel.NewFileCommand.Execute(null);

            Assert.AreNotEqual(initialLibraryViewModel, mainWindowViewModel.LibraryViewModel);
        }
    }
}
