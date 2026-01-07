using LogicLayer;
using System.Configuration;
using System.Data;
using System.Windows;

namespace HMI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStart(object sender, EventArgs e)
        {
            SorterStrategy sorters = new SorterStrategy();
            sorters.RegisterSorter("Tri à bulles", new BubbleSort());
            sorters.RegisterSorter("Tri par insertion", new InsertSort());
            sorters.RegisterSorter("Tri rapide", new QuickSort());
            MainWindow = new MainWindow(sorters);
            MainWindow.Show();
        }
    }

}
