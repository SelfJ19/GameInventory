using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Clue:Item
    {
        #region Attributes
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class
        /// </summary>
        private string personInciminated { get; set; }
        private bool accuracy { get; set; }
        #endregion

        #region Parameterized()
        /// <summary>
        /// Parameterized Constructor that also uses the Item parameterized constructor
        /// </summary>
        /// <param name="name">used to set Name from the parent class Item</param>
        /// <param name="description">used to set Description from the parent class Item</param>
        /// <param name="weight">used to set Weight from the parent class Item</param>
        /// <param name="value">used to set Value from the parent class Item</param>
        /// <param name="incriminates">used to set personIncriminated equal to incriminates</param>
        /// <param name="isAccurate">used to set accuracy equal to isAccurate</param>
        public Clue(string name, string description, double weight, double value, string incriminates, bool isAccurate) : base(name, description, weight, value)
        {
            personInciminated = incriminates;
            accuracy = isAccurate;
        }
        #endregion
    }
}
