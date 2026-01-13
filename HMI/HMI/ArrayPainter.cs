using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

using LogicLayer;

namespace HMI
{
    /// <summary>
    /// Classe qui gère l'affichage du tableau 
    /// </summary>
    internal class ArrayPainter : SorterObserver
    {
        #region--Atributs--
        /// <summary>
        /// Canva sur lequel dessiner
        /// </summary>
        Canvas canvas;
        /// <summary>
        /// Brosse avec laquelle dessiner
        /// </summary>
        Brush brush;
        #endregion

        #region--Constructeur--
        /// <summary>
        /// Constructeur de l'arraypainter avec son canvas et sa brush
        /// </summary>
        /// <param name="canvas">Canva sur lequel dessiner</param>
        /// <param name="brush">Brosse avec laquelle dessiner</param>
        public ArrayPainter(Canvas canvas, Brush brush)
        {
            this.canvas = canvas; 
            this.brush = brush;
        }
        #endregion

        #region--Méthodes--
        /// <summary>
        /// Méthode pour generer les lignes proportionelles aux valeurs du tableau
        /// </summary>
        /// <param name="values">tableau à representer en lignes</param>
        public void InitArray(int[] values)
        {
            canvas.Children.Clear();
            
            int maxValue = values.Max();

            double taille;
            if (maxValue > 0)
            {
                taille = canvas.ActualWidth / maxValue;
            }
            else
            {
                taille = 1;
            }

            for (int i = 0; i < values.Length; i++)
            {
                Line line = new Line();

                line.Y1 = i;
                line.Y2 = i;

                line.X1 = 0;
                line.X2 = values[i] * taille;

                line.Stroke = brush;
                line.StrokeThickness = 1;

                canvas.Children.Add(line);
            }
        }

        /// <summary>
        /// Méthode appelée lorsqu'une valeur du tableau change pendant le tri
        /// </summary>
        /// <param name="i">Index de la ligne à modifier</param>
        /// <param name="newValue">Nouvelle valeur</param>
        public void ChangeValue(int i, int newValue)
        {
            canvas.Dispatcher.Invoke(() =>
            {
                // Récupère la ligne correspondante
                if (i < canvas.Children.Count)
                {
                    Line line = (Line)canvas.Children[i];
                    
                    // Calcule la nouvelle taille
                    int maxValue = 500; 
                    double taille = canvas.ActualWidth / maxValue;
                    
                    // Met à jour la ligne
                    line.X2 = newValue * taille;
                }
            });
        }
        #endregion
    }
}
