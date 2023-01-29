using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
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
            string info = "\nClues-----------------------------------";
            
            // Loop that looks at all items in the list Contents
            foreach (Item item in Contents)
            {
                // loop that checks if an item is a Clue then that is what is added to the string to print
                if (item is Clue)
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
