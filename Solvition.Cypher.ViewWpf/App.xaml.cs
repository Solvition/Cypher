using Solvition.Cypher.ViewWpf.Views;
using System.Windows;

namespace Solvition.Cypher.ViewWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindowView();
            mainWindow.Show();
        }
    }
}
