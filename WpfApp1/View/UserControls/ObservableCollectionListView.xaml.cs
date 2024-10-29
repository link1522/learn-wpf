using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.View.UserControls
{
    public partial class ObservableCollectionListView : UserControl
    {
        public ObservableCollectionListView()
        {
            DataContext = this;
            entries = new ObservableCollection<string>();

            InitializeComponent();
        }

        // 使用 ObservableCollection 才能使 UI 更新
        private ObservableCollection<string> entries;

        // ObservableCollection 預設就會更新 props
        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            Entries.Remove(selectedItem);
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }
    }
}
