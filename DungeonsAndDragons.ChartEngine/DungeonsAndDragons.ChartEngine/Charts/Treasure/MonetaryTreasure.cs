using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    /// <summary>
    /// This is Declaring the class MonetaryTreasure with access modifier of public.
    /// <example>Classes are declared by using the class keyword followed by a unique identifier, as shown in the following example:
    /// <example>[access modifier] - [class] - [identifier] { Fields, properties, methods and events go here...}</example>
    /// <example>The class keyword is preceded by the access level. Because public is used in this case, anyone can create instances of this class.</example>
    /// <example>The name of the class follows the class keyword. The name of the class must be a valid C# identifier name.</example>
    /// <example>The remainder of the definition is the class body, where the behavior and data are defined.</example>
    /// <example>Fields, properties, methods, and events on a class are collectively referred to as class members.</example>
    /// </summary>

    public class MonetaryTreasure
    {
        #region Properties

        /// <summary>
        /// Name of the types of treasure.
        /// <example>Copper, Silver, Gold, etc.</example>
        /// </summary>
        public string TreasureName { get; set; }

        /// <summary>
        /// Type of dice.
        //todo are we even using this? If so the name should be more descriptive not sure what exactly this is.
        /// </summary>
        public Dice Dice { get; set; }

        /// <summary>
        /// The amount of tresure. If group of monsters/lair then it is in the 1000's. If solo/wandering monsters it is in pieces per monster.
        /// </summary>
        public int TreasureAmount { get; set; }

        /// <summary>
        /// This is a percentange from 01-100.
        /// </summary>
        ///<remarks>D100 Roll</remarks>
        public double Percent { get; set; }

        /// <summary>
        /// This is the Number of Dice that gets rolled. From 1 die up to 10, could be more but not often.
        /// </summary>
        public int NumberOfDice { get; set; }

        /// <summary>
        /// This is the Highest value that the rolled dice can achive. Determined by adding up the highest value on each die.
        /// <exeample>If you have 3d6, the highest value is 6+6+6 for a total of 18.</exeample>
        /// </summary>
        public int MaxRollValue { get; set; }

        #endregion Properties

        //todo should there be a region here?
        /// <summary>
        /// instantiate new MonitaryTreasure.
        /// </summary>
        /// <param name="treasureName">Name of the treasure types aka Copper,Silver, Gold, etc.</param>
        /// <param name="treasureAmount">This is the amount of the treasure. For group treasure(A-O) its in thousands. For solo (P-V) it is in pieces per monster.</param>
        /// <param name="numberOfDice">This is the number of dice that get rolled.</param>
        /// <param name="maxRollValue">This is the Highest value that the rolled dice can achive. Determined by adding up the highest value on each die.</param>
        /// <param name="percent">This is a percentange from 01-100.</param>
        public MonetaryTreasure(string treasureName, int treasureAmount, int numberOfDice, int maxRollValue, double percent)//todo This is a constructor called MonetaryTreasure which 
        {//todo passes in the following parameters. Yes?
            TreasureName = treasureName;
            Dice = GetDice(maxRollValue, numberOfDice);
            TreasureAmount = treasureAmount;
            NumberOfDice = numberOfDice;
            MaxRollValue = maxRollValue;
            Percent = percent;
        }
        //todo endregion of some type here?

        //todo should there be a region here?
        public Dice GetDice(int maxRollValue, int numberOfDice)//todo This is a Method called GetDice which is type Dice. Dice is an enum. Yes?
        {

            if(numberOfDice == 0)
            {
                return Dice.DNull;
            }
            int diceValue = maxRollValue / numberOfDice; 
            return (Dice)diceValue;
        }
    }
    //todo what is this     <!---->
}
