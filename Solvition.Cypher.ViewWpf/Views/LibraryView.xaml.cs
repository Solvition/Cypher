using System.Windows.Controls;

namespace Solvition.Cypher.ViewWpf.Views
{
    /// <summary>
    /// Interaction logic for LibraryView.xaml
    /// </summary>
    public partial class LibraryView : UserControl
    {
        public LibraryView()
        {
            InitializeComponent();
        }

        private void _expander_Expanded(object sender, System.Windows.RoutedEventArgs e)
        {
            var expander = sender as Expander;
            if (expander is null)
            {
                return;
            }

            foreach (var child in _grid.Children)
            {
                if (child is Expander && child != sender)
                {
                    ((Expander)child).IsExpanded = false;
                }
            }
        }
    }
}
