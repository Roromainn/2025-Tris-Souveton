using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicLayer
{
    public class BubbleSort : Sorter
    {
        #region Propriétés
        /// <summary>
        /// Nom pour l'affichage dans l'ihm
        /// </summary>
        public string Name { get; } = "Tri a bulle";
        #endregion

        #region Méthodes 
        public override int Sort(int[] values)
        {
            int n = values.Length;
            bool swapped = false;
            int operationCount = 0;
            
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    operationCount++; // Compte chaque comparaison
                    if (values[i] > values[i + 1])
                    {
                        // swap
                        int temp = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = temp;
                        
                        NotifyChange(i, values[i]);
                        NotifyChange(i + 1, values[i + 1]);
                        
                        swapped = true;
                    }
                }
            }
            while (swapped);
            
            return operationCount;
        }
        #endregion
    }
}
