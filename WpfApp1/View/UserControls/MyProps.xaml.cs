using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.View.UserControls
{
    public partial class MyProps : UserControl
    {
        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register(
            "Items",
            typeof(ObservableCollection<string>),
            typeof(MyProps),
            new PropertyMetadata(new ObservableCollection<string>())
        );

        public ObservableCollection<string> Items
        {
            get => (ObservableCollection<string>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title",
            typeof(string),
            typeof(MyProps),
            new PropertyMetadata("Default Title")
        );

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public MyProps()
        {
            InitializeComponent();
            tb.Text = Title;
            lvEl.ItemsSource = Items;
        }
    }
}
