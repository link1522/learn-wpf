using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.View.UserControls
{
    /// <summary>
    /// Interaction logic for SetTextInput.xaml
    /// </summary>
    public partial class SetTextInput : UserControl, INotifyPropertyChanged
    {
        public SetTextInput()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set { 
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BoundText = "Set by button";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
