using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class JewelryTreasure
    {
        #region Properties
        /// <summary>
        /// Name of the treasure.
        /// </summary>
        public string TreasureName { get; set; }//confused by this. If it is the TreasureName and it means all jewelry why call it TreasureName?

        /// <summary>
        /// Type of dice.
        /// </summary>
        public Dice Dice { get; set; }//don't understand this. Where is this used?

        /// <summary>
        /// Value of jewelry
        /// </summary>

        public int MinimumValue { get; set; } //Is this actually a value? Or is it the number of Jewelry pieces?

        public int MaximumValue { get; set; }// same as above, is it the value or the number of jewelry pieces? I think it is the number of pieces.

        public double Percent { get; set; }//this is the percentage chance of jewelry being in the treasure.

        public int NumberOfDice { get; set; }//This is number of dice rolled to determine the MinimumValue

        public int MaxRollValue { get; set; }//This is the highest number of items there can be of jewelry in the treasure.

        #endregion Properties

        public JewelryTreasure (string treasureName, int minimumValue, int maximumValue, int numberOfDice, int maxRollValue)
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
