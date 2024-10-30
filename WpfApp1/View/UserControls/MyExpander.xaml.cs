using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.View.UserControls
{
    public partial class MyExpander : UserControl
    {
        public MyExpander()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        }
    }
}
