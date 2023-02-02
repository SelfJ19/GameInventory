using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameInventory
{
    public class Weapon:Clue
    {
        #region Attributes
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class
        /// </summary>
        private int _damage { get; set; }
        private DamageType _damageType { get; set; }
        #endregion

        #region Parameterized()
        public Weapon(string name, string description, double weight, double value, string incriminates, bool isAccurate) : base(name, description, weight, value, incriminates, isAccurate)
        {
            _damage = 0;
            _damageType = DamageType.Slashing;
        }
        #endregion
    }
}
