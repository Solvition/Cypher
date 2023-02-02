using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solvition.Cypher.ViewModel.Commands;

namespace Solvition.Cypher.ViewModel.Test.Commands
{
    [TestClass]
    public class ActionCommandTests
    {
        [TestMethod]
        public void Execute_ExecutesAction()
        {
            var number = 0;
            Action addAction = () => number += 1;
            var command = new ActionCommand(addAction);

            command.Execute(null);

            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void Execute_CanExecuteIsFalse_WillStillExecute()
        {
            var number = 0;
            Action addAction = () => number += 1;
            var canExecuteFunc = new Func<bool>(() => false);
            var command = new ActionCommand(addAction, canExecuteFunc);

            command.Execute(null);

            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void CanExecute_NoPredicateInConstructor_ReturnTrue()
        {
            var command = new ActionCommand(() => { } ) ;

            Assert.IsTrue(command.CanExecute(null));
        }

        [TestMethod]
        public void CanExecute_HasPredicateInConstructor_ReturnsPredicateReturn()
        {
            var boolValue = false;
            var predicate = new Func<bool>(() => boolValue);

            var command = new ActionCommand(() => { }, predicate);

            Assert.IsFalse(command.CanExecute(null));
        }
    }
}
