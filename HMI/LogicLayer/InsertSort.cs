using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicLayer
{
    public class InsertSort : Sorter
    {
        #region Propriétés
        /// <summary>
        /// Nom pour l'affichage dans l'ihm
        /// </summary>
        public string Name { get; } = "Tri par insertion";
        #endregion

        #region Méthodes
        public override int Sort(int[] values)
        {
            int operationCount = 0;
            
            for (int i = 1; i < values.Length; i++)
            {
                int key = values[i];
                int j = i - 1;
                while (j >= 0 && values[j] > key)
                {
                    operationCount++; 
                    values[j + 1] = values[j];
                    NotifyChange(j + 1, values[j + 1]); 
                    j--;
                }
                // Compte la dernière comparaison qui a échoué 
                if (j >= 0) operationCount++;
                
                values[j + 1] = key;
                NotifyChange(j + 1, values[j + 1]); 
            }
            
            return operationCount;
        }
        #endregion
    }
}
