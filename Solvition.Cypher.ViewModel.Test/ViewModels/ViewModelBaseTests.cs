using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace Solvition.Cypher.ViewModel.Test.ViewModels
{
    [TestClass]
    public class ViewModelBaseTests
    {
        [TestMethod]
        public void PropertyChanged_WhenPropertyChanged_IsFiredOnlyOnce()
        {
            var propertyToChange = nameof(FakeViewModel.IntProperty);
            var changeCount = 0;

            var countHandler = new PropertyChangedEventHandler((s, e) =>
            {
                if (e.PropertyName == propertyToChange)
                {
                    changeCount++;
                }
            });

            var viewModel = new FakeViewModel();
            viewModel.PropertyChanged += countHandler;
            viewModel.IntProperty++;

            var expectedCount = 1;

            Assert.AreEqual(expectedCount, changeCount);
        }

        [TestMethod]
        public void PropertyChanged_WhenRaisedByName_IsFiredOnlyOnce()
        {
            var propertyToChange = nameof(FakeViewModel.IntProperty);
            var changeCount = 0;

            var countHandler = new PropertyChangedEventHandler((s, e) =>
            {
                if (e.PropertyName == propertyToChange)
                {
                    changeCount++;
                }
            });

            var viewModel = new FakeViewModel();
            viewModel.PropertyChanged += countHandler;
            viewModel.RaisePropertyByName("IntProperty");

            var expectedCount = 1;

            Assert.AreEqual(expectedCount, changeCount);
        }
    }
}
