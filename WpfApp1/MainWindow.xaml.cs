using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void appendBtn_Click(object sender, RoutedEventArgs e)
        {
            myProps.Title = "7777";
            myProps.Items.Add("III");
        }
    }
}