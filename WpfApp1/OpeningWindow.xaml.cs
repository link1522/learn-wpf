using System.Windows;
using WpfApp1.View;

namespace WpfApp1
{
    public partial class OpeningWindow : Window
    {
        public OpeningWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow(this);
            Opacity = 0.4;
            modalWindow.ShowDialog();
            Opacity = 1;
            
            if (modalWindow.Success)
            {
                txtInput.Text = modalWindow.Input;
            }
        }
    }
}
