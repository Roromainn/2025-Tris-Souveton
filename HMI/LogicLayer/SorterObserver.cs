using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Interface pour observer les changements dans un tri
    /// </summary>
    public interface SorterObserver
    {
        /// <summary>
        /// Méthode appelée lorsqu'une valeur du tableau change
        /// </summary>
        /// <param name="i">Index de la valeur modifiée</param>
        /// <param name="newValue">Nouvelle valeur</param>
        void ChangeValue(int i, int newValue);
    }
}
