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
    /// Creates the class ItemFactory with all its elements
    /// </summary>
    public class ItemFactory
    {
        #region Attributes
        /// <summary>
        /// Data that belongs to and describes an object of the class ItemFactory, creates an random variable to be used to make things random in the class methods, makes arrays to store values for weapon names, weapon descriptions, clue names, clue descriptions and who is incriminated
        /// </summary>
        Random random = new Random();

        private string[] weaponName = new string[] { "Sword", "Pole Arm", "Katana", "Blunderbuss", "Shield", "Axe", "Short Sword", "Great Sword", "Flintlock Pistol", "Long Bow"};
        private string[] weaponDescription = new string[] { "A bright shiny sword", "A heavy stick for hitting things", "A japanese style sword that has a curved edge", "A weapon that shoots metal pellets in a wide spread dealing significant damgage up close", "Blocks incoming attacks cannot be used with two-handed weapons", "A wicked looking axe", "A sword with reduced range but is faster than a normal sword", "A beatiful creation that must be used by two-hands", "A weapon that shoots metal pellets faster than the blunderbuss and can equip one in each hand", "A bow of elven creation with intricate detail" };
        private string[] clueName = new string[] { "Letter", "Shirt", "Message on the wall", "Picture", "Broken bottle"};
        private string[] clueDescription = new string[] { "A threatening letter from Fred", "A bloody shirt", "Someone wrote a message in blood", "A picture of the missing child", "The bottle has blood on the end that is broken"};
        private string[] incriminates = new string[] { "John", "Chris", "Christian", "Bob", "Anna", "Jessee"};
        #endregion

        #region MakeRandomClue()
        /// <summary>
        /// creates a clue with random attributes, uses the Math.Round to round the random double that is created to make the doubles easier to read without multiple decimal values
        /// </summary>
        /// <returns>new clue that was created</returns>
        public Clue MakeRandomClue()
        {
            int rand = random.Next(clueName.Length);
            Clue newClue = new Clue(clueName[rand], clueDescription[rand], Math.Round(random.NextDouble()+1), Math.Round(random.NextDouble()+1), incriminates[rand], random.Next(2) == 1);
            return newClue;            
        }
        #endregion

        #region parameterized MakeRandomClue()
        /// <summary>
        /// creates a clue with random attributes but sets the incriminates and isAccurate values
        /// </summary>
        /// <param name="isAccurate">sets it equal to accuracy from Clue.cs</param>
        /// <param name="incriminates">sets it equal to personIncriminated from Clue.cs</param>
        /// <returns>new clue that is created</returns>
        public Clue MakeRandomClue(bool isAccurate, string incriminates)
        {
            int rand = random.Next(clueName.Length);
            Clue newClue = new Clue(clueName[rand], clueDescription[rand], Math.Round(random.NextDouble()+1), Math.Round(random.NextDouble()+1), incriminates, isAccurate);            
            return newClue;
        }
        #endregion

        #region MakeRandomItem()
        /// <summary>
        /// creates a random item by calling the MakeRandomClue method and the MakeRandomWeapon method
        /// </summary>
        /// <returns>random item that is created</returns>
        public Item MakeRandomItem()
        {
            // if statement that randomly creates a random clue or weapon by making the random values large enough to be considered random and if its less than 5000 it creates a clue else it creates a weapon
            if (random.Next(10000) < 5000)
            {
                return MakeRandomClue();
            }
            else
            {
                // returns the MakeRandomWeapon method by calling it and passing the RetRandomRarityType method to make the weapon have a random rarity
                return MakeRandomWeapon(GetRandomRarityType());
            }
        }
        #endregion

        #region MakeRandomWeapon(rarity)
        /// <summary>
        /// Creates a new weapon with random attributes but sets the rarity level, sets the damage type using the random damage type method
        /// </summary>
        /// <param name="rarity">rarity type</param>
        /// <returns>a new weapon</returns>
        public Weapon MakeRandomWeapon(Rarity rarity)
        {
            int rand = random.Next(weaponName.Length);
            int charRand = random.Next(incriminates.Length);
            Weapon newWeapon = new Weapon(weaponName[rand], weaponDescription[rand], Math.Round(random.NextDouble()*5), Math.Round(random.NextDouble()*20), incriminates[charRand], random.Next(2) == 1);
            newWeapon.SetRarity(rarity);
            newWeapon.SetDamageType(GetRandomDamageType());
            return newWeapon;
        }
        #endregion

        #region MakeRandomWeapon(rarity,isAccurate,incriminates)
        /// <summary>
        /// makes a new weapon with random attributes and sets the rarity, inciminates and isAccurate attributes equal to the values passed in
        /// </summary>
        /// <param name="rarity">rarity type</param>
        /// <param name="isAccurate">boolean value is it accurate</param>
        /// <param name="incriminates">person incriminated</param>
        /// <returns>new weapon</returns>
        public Weapon MakeRandomWeapon(Rarity rarity, bool isAccurate, string incriminates)
        {
            int rand = random.Next(weaponName.Length);
            Weapon newWeapon = new Weapon(weaponName[rand], weaponDescription[rand], random.NextDouble(), random.NextDouble(), incriminates, isAccurate);
            newWeapon.SetRarity(rarity);
            newWeapon.SetDamageType(GetRandomDamageType());
            return newWeapon;
        }
        #endregion

        #region GetRandomDamageType()
        /// <summary>
        /// creates the method to get the damage type using the random.next method used in an if-else-if loop
        /// </summary>
        /// <returns>damage type</returns>
        private DamageType GetRandomDamageType()
        {
            DamageType damageType;

            int rand = random.Next(3);

            if (rand == 0)
            {
                damageType = DamageType.Slashing;
            }
            else if (rand == 1)
            {
                damageType = DamageType.Bludgeoning;
            }
            else
            {
                damageType = DamageType.Piercing;
            }

            return damageType;
        }
        #endregion

        #region GetRandomRarityType()
        /// <summary>
        /// creates the method to get the rarity type using the random.next method used in an if-else-if loop
        /// </summary>
        /// <returns>rarity type</returns>
        private Rarity GetRandomRarityType()
        {
            Rarity rarityType;

            int rand = random.Next(3);

            if (rand == 0)
            {
                rarityType = Rarity.Common;
             }
            else if (rand == 1)
            {
                rarityType = Rarity.Uncommon;
            }
            else
            {
                rarityType = Rarity.Rare;
            }

            return rarityType;
        }
        #endregion
    }
}
