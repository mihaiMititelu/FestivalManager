using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TSP_Wpf.WcfServiceRef;

namespace TSP_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private FestivalClient dataClient;
        private Festival selectedFestival;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource festivalViewSource = ((CollectionViewSource)(this.FindResource("festivalViewSource")));
            dataClient = new FestivalClient();
            dataGrid.ItemsSource = dataClient.GetAllFestivals();

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedFestival = (Festival)dataGrid.SelectedItem;
            festivalDetailsGrid.DataContext = selectedFestival;
            performerNames.Items.Clear();
            foreach (var p in selectedFestival.Performers)
            {
                performerNames.Items.Add("•" + p.Name);
            }
        }

        private void add_new_festival(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("merge");
        }

        private void delete_festival(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("merge");

        }

        private void edit_festival(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("merge");

        }

        private void change_location(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("merge");

        }
    }
}
