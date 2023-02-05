using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameInventory
{
    /// <summary>
    /// creates the weapon class which is a subclass of clue
    /// </summary>
    public class Weapon:Clue
    {
        #region Attributes
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class Weapon
        /// </summary>
        protected int _damage { get; set; }
        protected DamageType _damageType { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="damageType"></param>
        public void SetDamageType(DamageType damageType) => _damageType = damageType;

        #region Parameterized()
        /// <summary>
        /// Parameterized Constructor that also uses the Clues parameterized constructor
        /// </summary>
        /// <param name="name">used to set Name from the parent class Clue</param>
        /// <param name="description">used to set the Description from the parent class Clue</param>
        /// <param name="weight">used to set the Weight from the parent class Clue</param>
        /// <param name="value">used to set the Value from the parent class Clue</param>
        /// <param name="incriminates">used to set the incriminates from the parent class Clue</param>
        /// <param name="isAccurate">used to set the isAccurate from the parent class Clue</param>
        public Weapon(string name, string description, double weight, double value, string incriminates, bool isAccurate) : base(name, description, weight, value, incriminates, isAccurate)
        {
            int damage = new Random().Next(1,50);
            _damage = damage;
            _damageType = DamageType.Piercing;
        }
        #endregion

        #region ToString()
        /// <summary>
        /// formats the output to the screen for Weapon class
        /// </summary>
        /// <returns>how the output should be displayed to the screen</returns>
        public override string ToString()
        {
            string info = base.ToString();

            info += $"\nDamage Type: \t{_damageType}\n";
            info += $"Damage Dealt: \t{_damage}";

            return info;
        }
        #endregion
    }
}
