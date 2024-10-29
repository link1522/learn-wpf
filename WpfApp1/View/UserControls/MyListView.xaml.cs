using System.Collections;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp1.View.UserControls
{
    public partial class MyListView : UserControl
    {
        public MyListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtEntry.Text)) return;

            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            //object selectedItem = lvEntries.SelectedItem;
            var items = lvEntries.SelectedItems;
            MessageBoxResult dialogResult = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "Sure?", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (dialogResult == MessageBoxResult.Cancel) return;
            
            var itemList = new ArrayList(items);
            foreach (var item in itemList)
            {
                lvEntries.Items.Remove(item);
            }
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}
