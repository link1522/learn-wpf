using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.View.UserControls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you agree?", "agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MessageBox.Show("Success!");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileDialog.InitialDirectory = Path.Combine(desktopPath, "public");
            fileDialog.Title = "Select a file";

            bool? success = fileDialog.ShowDialog();

            if (success == true)
            {
                string path = fileDialog.FileName;
                string fileName = fileDialog.SafeFileName;
                tbInfo.Text = fileName;
            }
            else
            {

            }
        }
    }
}
