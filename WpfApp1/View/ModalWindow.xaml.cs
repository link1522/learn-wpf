using Accessibility;
using System.Windows;

namespace WpfApp1.View
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }

        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Success = false;
            Close();
        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
                btnOk.IsEnabled = false;
            else
                btnOk.IsEnabled = true;
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
