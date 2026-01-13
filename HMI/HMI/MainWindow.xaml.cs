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
        #region--Attributs--
        /// <summary>
        /// Tableau d'entier
        /// </summary>
        int[] tab;
        /// <summary>
        /// Tri pour le tableau
        /// </summary>
        SorterStrategy strategy;
        #endregion
        #region--Constructeur--
        public MainWindow(SorterStrategy sorters)
        {
            InitializeComponent();
            strategy = sorters;
            foreach (string item in sorters.Names.Keys)
            {
                choix.Items.Add(item);
            }

        }
        #endregion

        #region--Méthodes--
        /// <summary>
        /// Affiche un tableau avec des valeurs aléatoires
        /// </summary>
        private void GenerateRandomValues(object sender, RoutedEventArgs e)
        {
            ArrayGenerator generator = new ArrayGenerator();
            ArrayPainter painter = new ArrayPainter(this.MainCanvas, Brushes.Blue);

            tab = generator.GenerateRandomArray((int)MainCanvas.ActualHeight, 0, 500);

            ListValues.Items.Clear();
            foreach (int value in tab)
            {
                ListValues.Items.Add(value);
            }

            painter.InitArray(tab);

        }

        /// <summary>
        /// Trie le tableau de valeur
        /// </summary>
        private async void DoSort(object sender, RoutedEventArgs e)
        {
            if (tab == null)
            {
                MessageBox.Show("tableau non généré");
                return;
            }

            Sorter sort = ChooseSorter();
            
            // Enregistre l'observateur avant de lancer le tri
            ArrayPainter painter = new ArrayPainter(this.MainCanvas, Brushes.Blue);
            sort.RegisterObserver(painter);
            
            await Task.Run(() => sort.Sort(tab));

            painter.InitArray(tab);
        }

        /// <summary>
        /// Choisi le tri voulu par l'utilisateur dans la combobox
        /// </summary>
        /// <returns></returns>
        private Sorter ChooseSorter()
        {
            SorterStrategy strat = strategy;
            return strat.ChooseSorter((string)choix.SelectedItem);
        }

        #endregion

    }
}