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
        int[] tab;
        #endregion
        #region--Constructeur--
        public MainWindow()
        {
            InitializeComponent();
            choix.Items.Add(new NoSort());
            choix.Items.Add(new BubbleSort());
            choix.Items.Add(new InsertSort());
            choix.DisplayMemberPath = "Name";

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
        private void DoSort(object sender, RoutedEventArgs e)
        {
            if (tab == null)
            {
                MessageBox.Show("tableau non généré");
                return;
            }


            Sorter sort = ChooseSorter();
            sort.Sort(tab);


            //Actualise l'affichage
            ArrayPainter painter = new ArrayPainter(this.MainCanvas, Brushes.Blue);
            painter.InitArray(tab);
        }

        private Sorter ChooseSorter()
        {
            Sorter tri = (Sorter)choix.SelectedItem;
            return tri;
        }

        #endregion

    }
}