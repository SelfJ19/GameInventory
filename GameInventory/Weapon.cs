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

        #region SetDamageType()
        /// <summary>
        /// One line setter method that sets the damage type of a weapon
        /// </summary>
        /// <param name="damageType">damage type</param>
        public void SetDamageType(DamageType damageType) => _damageType = damageType;
        #endregion

        #region Parameterized()
        /// <summary>
        /// Parameterized Constructor that also uses the Clues parameterized constructor and sets the Weapons damage and damage type to default values but makes the damage a random amount from 1-50
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
        /// formats the output to the screen for Weapon class using the parent classes ToString and adding to it 
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
