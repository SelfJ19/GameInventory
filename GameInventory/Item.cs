using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Item
    {
        #region Attributes()
        /// <summary>
        /// 
        /// </summary>
        protected string Description { get; set; }
        protected string Name { get; set; }
        protected Rarity Rarity { get; set; }
        protected double Value { get; set; }
        protected double Weight { get; set; }
        #endregion

        #region Item()
        public Item (string name, string description, double weight, double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }
        #endregion

        #region ToString()
        public string ToString()
        {
            string info = "";

            info += $"Item name: \t{Name}";
            info += $"\nDescription: \t{Description}";
            info += $"\nWeight: \t{Weight} pounds";
            info += $"\nValue: \t\t ${Value}";

            return info;
        }
        #endregion
    }
}
