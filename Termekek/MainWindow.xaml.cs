using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Termekek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> termekek = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            lbox_termekek.ItemsSource = termekek;
        }

        private void btn_hozzaadas_Click(object sender, RoutedEventArgs e)
        {
            if (tbox_input.Text != null)
            {
                termekek.Add(tbox_input.Text);
                lbox_termekek.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Invalid név!", "Invalid név!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            tbox_input.Text = "";
            tb_sum.Text = "Termékek száma:" + termekek.Count;
        }
        private void btn_torles_Click(object sender, RoutedEventArgs e)
        {
            if (lbox_termekek.SelectedItem != null)
            {
                string kivalasztott = lbox_termekek.SelectedItem.ToString();
                termekek.Remove(kivalasztott);
                lbox_termekek.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nincs kijelölt termék!", "Nincs kijelölt termék!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_torlesAll_Click(object sender, RoutedEventArgs e)
        {
            if (termekek.Count > 0)
            {
                termekek.Clear();
                tb_sum.Text = "Termékek száma:" + termekek.Count;
                lbox_termekek.Items.Refresh();
            }
        }

        private void lbox_termekek_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            tb_sum.Text = "Termékek száma:" + termekek.Count+1;
        }
    }
}