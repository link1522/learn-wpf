using System.ComponentModel;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
            }
        }

        private void btnSet_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BoundText = "Set by button";
        }
    }
}
