///////////////////////////////////////////////////////////////////////////////
//
// Author: Jason Self, selfj1@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 1
// Description: Creates a backpack of items using a class called ItemFactory
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    /// <summary>
    /// creates the public class Item that contains the classes attributes and methods
    /// </summary>
    public class Item
    {
        #region Attributes()
        /// <summary>
        /// Data that belongs to and describes an object of the class Item
        /// </summary>
        protected string Description { get; set; }
        protected string Name { get; set; }
        protected Rarity Rarity { get; set; }
        protected double Value { get; set; }
        protected double Weight { get; set; }
        #endregion

        #region SetRarity
        /// <summary>
        /// One line setter method that sets the rarity of an item
        /// </summary>
        /// <param name="rarity">rarity type</param>
        public void SetRarity(Rarity rarity) => Rarity = rarity;
        #endregion

        #region Item()
        /// <summary>
        /// Constructor that takes in values and sets them equal to the class Item's attributes
        /// </summary>
        /// <param name="name">use to set the Name attribute</param>
        /// <param name="description">used to set the  Description attribute</param>
        /// <param name="weight">used to set the Weight attribute</param>
        /// <param name="value">used to set the Value attribute</param>
        public Item (string name, string description, double weight, double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }
        #endregion

        #region ToString()
        /// <summary>
        /// formats the output of the Item class
        /// </summary>
        /// <returns>how the output should be displayed to the screen</returns>
        public override string ToString()
        {
            string info = "";

            if(Rarity != Rarity.Common)
            {
                info += $"Item name: \t{Rarity} {Name}";
            }
            else 
            info += $"Item name: \t{Name}";
            info += $"\nDescription: \t{Description}";
            info += $"\nWeight: \t{Weight} pounds";
            info += $"\nValue: \t\t${Value}";

            return info;
        }
        #endregion
    }
}
