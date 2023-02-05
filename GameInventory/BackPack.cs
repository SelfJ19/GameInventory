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
    /// Creates the class BackPack with all its elements
    /// </summary>
    public class BackPack
    {
        #region Attributes
        /// <summary>
        /// Creates the a List of Contents that makes up what is inside the backpack
        /// </summary>
        private List<Item> Contents { get; set; }
        #endregion

        #region Add()
        /// <summary>
        /// Creates the Add method using item
        /// </summary>
        /// <param name="item">item to be added to the List Contents</param>
        public void Add(Item item)
        {
            Contents.Add(item);
        }
        #endregion

        #region Backpack()
        /// <summary>
        /// Creates and Instantiates an empty List named Contents
        /// </summary>
        public BackPack()
        {
            Contents = new List<Item>();
        }
        #endregion

        #region ListClues()
        /// <summary>
        /// Creates the ListClues method for how clues should be displayed in output
        /// </summary>
        /// <returns>how clues string info should be formatted</returns>
        public string ListClues()
        {
            string info = "\n\nClues-------------------------------------------";
            
            // Loop that looks at all items in the list Contents
            foreach (Item item in Contents)
            {
                // loop that checks if an item is not a weapon then that is what is added to the string to print
                if (item is not Weapon)
                {
                    info += $"\n{item}";
                    info += "\n------------------------------------------------";
                }
            }
            return info;
        }
        #endregion

        #region ListItems()
        /// <summary>
        /// Creates the ListItems method and calls the ListWeapons method and the ListClues method
        /// </summary>
        /// <returns>how items string info should be formatted</returns>
        public string ListItems()
        {
            string info = ListWeapons();
            info += ListClues();
            return info;
        }
        #endregion

        #region ListWeapons()
        /// <summary>
        /// Creates the ListWeapons method and formats it to display to the screen
        /// </summary>
        /// <returns>how weapons string info should be formatted</returns>
        public string ListWeapons()
        {
            string info = "\nWeapons -----------------------------------------";
            // Loop that looks at all items in the list Contents
            foreach (Item item in Contents)
            {
                // loop that checks if an item is a Weapon then that is what is added to the string to print
                if (item is Weapon)
                {
                    info += $"\n{item}";
                    info += "\n------------------------------------------------";
                }
            }
            return info;
        }
        #endregion
    }
}
