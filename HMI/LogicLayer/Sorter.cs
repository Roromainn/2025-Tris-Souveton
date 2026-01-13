using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Classe abstraite pour trier un tableau avec support du pattern Observer
    /// </summary>
    public abstract class Sorter
    {
        #region Attributs
        /// <summary>
        /// Liste des observateurs
        /// </summary>
        private List<SorterObserver> observers = new List<SorterObserver>();
        #endregion

        #region Méthodes
        /// <summary>
        /// Enregistre un observateur
        /// </summary>
        /// <param name="observer">Observateur à enregistrer</param>
        public void RegisterObserver(SorterObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Notifie tous les observateurs d'un changement de valeur
        /// </summary>
        /// <param name="i">Index de la valeur modifiée</param>
        /// <param name="newValue">Nouvelle valeur</param>
        protected void NotifyChange(int i, int newValue)
        {
            foreach (var observer in observers)
            {
                observer.ChangeValue(i, newValue);
            }
        }

        /// <summary>
        /// Tri un tableau
        /// </summary>
        /// <param name="values">tableau d'entier a trier</param>
        /// <returns>Nombre d'opérations effectuées</returns>
        public abstract int Sort(int[] values);
        #endregion
    }
}
