using LogicLayer;
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

namespace HMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayGenerator generator = new ArrayGenerator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateRandomValues(object sender, RoutedEventArgs e)
        {
            int[] tab = generator.GenerateRandomArray(100, 0, 500);

            ListValues.Items.Clear();
            foreach (int value in tab)
            {
                ListValues.Items.Add(value);
            }
        }
    }
}