using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Realisation de l'interface Sorter
    /// </summary>
    public class NoSort : Sorter
    {
        #region Propriétés
        /// <summary>
        /// Nom pour l'affichage dans l'ihm
        /// </summary>
        public string Name { get; } = "No Sort";
        #endregion

        #region--Méthodes--
        public override void Sort(int[] values)
        {
        }
        #endregion
    }
}
