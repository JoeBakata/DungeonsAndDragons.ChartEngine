using System;
using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class GemValue
    {
        #region Properties
        /// <summary>
        /// The type of Gem found in the treasure
        /// <example>Topaz, Pearl, Ruby, etc.</example>
        /// </summary>
        public GemType GemType { get; set; }

        /// <summary>
        /// The gems minimum value in gold pieces.
        /// </summary>
        public int MinimumGPValue { get; set; }

        /// <summary>
        /// The minimum number of gems -- or so I think.
        /// </summary>
        public double MinimumRollValue { get; set; }

        /// <summary>
        /// The maximum number of gems -- or so I think.
        /// </summary>
        public double MaximumRollValue { get; set; }

        /// <summary>
        /// Refers to the Dice enum to get a dice type -- I think.
        /// </summary>
        public Dice Dice { get; set; }
        #endregion Properties

        /// <summary>
        /// Instantiate GemValue. Instantiate literally means "to create an instance of". In programming, this generally means to create an instance of an object.
        /// You do that by using a constructor. A constructor is a special method of a class that initializes an object of that class.
        /// Constructors have the same name as the class they're in, and because they always return an instance of that class, a return type isn't needed.
        /// </summary>
        /// <param name="gemType">Determines the types of gems in the treasure.</param>
        /// <param name="minimumGPValue">Determines the lowest value, in gold pieces, of the gems -- I think.</param>
        /// <param name="minimumRollValue">Not sure, see above.</param>
        /// <param name="maximumRollValue">Not sure, see above.</param>
        public GemValue(string gemType, int minimumGPValue, double minimumRollValue, double maximumRollValue)//GemValue constructor with arguements int minimumGPValue, int minimumRollValue,
        {                                                                                              // and maximumRollValue.
            GemType = GetGemType(gemType);
            MinimumGPValue = minimumGPValue;
            MinimumRollValue = minimumRollValue;
            MaximumRollValue = maximumRollValue;
            Dice = Dice.D100;
        }
        private GemType GetGemType(string gemType)
        {
            return (GemType)Enum.Parse(typeof(GemType), gemType);
        }

    }

}
