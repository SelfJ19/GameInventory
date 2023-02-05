using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    /// <summary>
    /// 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// 
        /// </summary>
        Random random = new Random();

        private string[] weaponName = new string[] { "Sword", "Pole Arm", "Katana", "Blunderbuss", "Shield", "Axe", "Short Sword", "Great Sword", "Flintlock Pistol", "Long Bow"};
        private string[] weaponDescription = new string[] { "A bright shiny sword", "A heavy stick for hitting things", "A japanese style sword that has a curved edge", "A weapon that shoots metal pellets in a wide spread dealing significant damgage up close", "Blocks incoming attacks cannot be used with two-handed weapons", "A wicked looking axe", "A sword with reduced range but is faster than a normal sword", "A beatiful creation that must be used by two-hands", "A weapon that shoots metal pellets faster than the blunderbuss and can equip one in each hand", "A bow of elven creation with intricate detail" };
        private string[] clueName = new string[] { "Letter", "Shirt", "Message on the wall", "Picture", "Broken bottle"};
        private string[] clueDescription = new string[] { "A threatening letter from Fred", "A bloody shirt", "Someone wrote a message in blood", "A picture of the missing child", "The bottle has blood on the end that is broken"};
        private string[] incriminates = new string[] { "John", "Chris", "Christian", "Bob", "Anna", "Jessee"};
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Clue MakeRandomClue()
        {
            int rand = random.Next(clueName.Length);
            Clue newClue = new Clue(clueName[rand], clueDescription[rand], Math.Round(random.NextDouble()+1), Math.Round(random.NextDouble()+1), incriminates[rand], random.Next(2) == 1);
            return newClue;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isAccurate"></param>
        /// <param name="incriminates"></param>
        /// <returns></returns>
        public Clue MakeRandomClue(bool isAccurate, string incriminates)
        {
            int rand = random.Next(clueName.Length);
            Clue newClue = new Clue(clueName[rand], clueDescription[rand], Math.Round(random.NextDouble()+1), Math.Round(random.NextDouble()+1), incriminates, isAccurate);            
            return newClue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Item MakeRandomItem()
        {
            if (random.Next(10000) < 5000)
            {
                return MakeRandomClue();
            }
            else
            {
                return MakeRandomWeapon(GetRandomRarityType());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rarity"></param>
        /// <returns></returns>
        public Weapon MakeRandomWeapon(Rarity rarity)
        {
            int rand = random.Next(weaponName.Length);
            int charRand = random.Next(incriminates.Length);
            Weapon newWeapon = new Weapon(weaponName[rand], weaponDescription[rand], Math.Round(random.NextDouble()*5), Math.Round(random.NextDouble()*20), incriminates[charRand], random.Next(2) == 1);
            newWeapon.SetRarity(rarity);
            newWeapon.SetDamageType(GetRandomDamageType());
            return newWeapon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rarity"></param>
        /// <param name="isAccurate"></param>
        /// <param name="incriminates"></param>
        /// <returns></returns>
        public Weapon MakeRandomWeapon(Rarity rarity, bool isAccurate, string incriminates)
        {
            int rand = random.Next(weaponName.Length);
            Weapon newWeapon = new Weapon(weaponName[rand], weaponDescription[rand], random.NextDouble(), random.NextDouble(), incriminates, isAccurate);
            newWeapon.SetRarity(rarity);
            newWeapon.SetDamageType(GetRandomDamageType());
            return newWeapon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
    }
}
