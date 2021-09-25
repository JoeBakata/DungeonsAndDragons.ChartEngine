using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class GemTreasure//This is Constructor for GemTreasure?
    {//the following are the properties of the GemTreasure class?
        #region Properties 

        /// <summary>
        /// Name of the treasure.
        /// </summary>
        public string TreasureName { get; set; }

        /// <summary>
        /// Type of dice.
        /// </summary>
        public Dice Dice { get; set; }//This is here because it is in the JewelryTreasure.cs. Not sure why or if I even need this.

        /// <summary>
        /// MinimumValue of the Gem. // Is not descriptive enough. Please help!
        /// </summary>
        public int MinimumValue { get; set; }
        /// <summary>
        /// See above ^^^.
        /// </summary>
        public int MaximumValue { get; set; }
        /// <summary>
        /// Percent. // Percent of what exactly? Percent chance there are gems in the loot? Or percent to determine which gem type there is?
        /// </summary>
        public double Percent { get; set; }
        /// <summary>
        /// Number of gems found in the treasure.
        /// </summary>
        public int NumberOfGems { get; set; }
        /// <summary>
        /// Number of the dice to roll.
        /// </summary>
        public int NumberOfDice { get; set; }
        /// <summary>
        /// Highest value of gems.
        /// </summary>
        public int MaxRollValue { get; set; }

        #endregion Properties


        public GemTreasure (string treasureName, int minimumValue, int maximumValue, int numberOfDice, int maxRollValue)
        {
            TreasureName = treasureName;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
            NumberOfDice = numberOfDice;
            MaxRollValue = maxRollValue;
            Dice = GetDice(maxRollValue, numberOfDice);
        }
        public Dice GetDice(int maxRollValue, int numberOfDice)
        {

            if (numberOfDice == 0)
            {
                return Dice.DNull;
            }
            int diceValue = maxRollValue / numberOfDice;
            return (Dice)diceValue;
        }


    }
}
