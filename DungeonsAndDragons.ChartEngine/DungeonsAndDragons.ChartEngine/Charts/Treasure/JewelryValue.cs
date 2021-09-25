using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class JewelryValue
    {
        #region Properties

        /// <summary>
        /// The types of jewelry found in the treasure.
        /// <example>crown, sceptre, necklace, etc.</example>
        /// </summary>
        public JewelryType JewelryType { get; set; }

        /// <summary>
        /// Lowest gold piece value of the jewelry.
        /// </summary>
        public int MinimumGPValue { get; set; }

        /// <summary>
        /// Highest gold piece value of the jewelry.
        /// </summary>
        public int MaximumGPValue { get; set; }

        #endregion Properties

        /// <summary>
        /// Instanstiate JewelryValue. Instantiate literally means "to create an instance of". In programming, this generally means to create an instance of an object.
        /// You do that by using a constructor. A constructor is a special method of a class that initializes an object of that class.
        /// Constructors have the same name as the class they're in, and because they always return an instance of that class, a return type isn't needed.
        /// </summary>
        /// <param name="jewelryType">Types of jewelry found in the treasure.</param>
        /// <param name="minimumGPValue">Lowest gold piece value of the jewelry.</param>
        /// <param name="maximumGPValue">Highest gold piece value of the jewelry.</param>
        public JewelryValue(string jewelryType, int minimumGPValue, int maximumGPValue)//JewelryValue constructor with arguements string jewelryType,
        {                                               //int minimumGPValue, int maximumGPValue.
            JewelryType = GetJewelryType(jewelryType);
            MinimumGPValue = minimumGPValue;
            MaximumGPValue = maximumGPValue;
        }

        #region Private Method
        private JewelryType GetJewelryType(string jewelryType)//GetJewelryType Method with access modifier of private and return type of JewleryType.
        {

            return (JewelryType)Enum.Parse(typeof(JewelryType), jewelryType);
        }
        #endregion Private Method
    }


}

