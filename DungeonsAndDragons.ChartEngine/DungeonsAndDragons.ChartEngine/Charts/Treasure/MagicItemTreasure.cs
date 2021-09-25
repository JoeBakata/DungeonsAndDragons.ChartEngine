using System;
using System.Collections.Generic;
using System.Linq;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts.Treasure
{
    public class MagicItemTreasure
    {
        #region Properties
        
        /// <summary>
        /// Get the type of dice using enum -- I think.
        /// </summary>
        public Dice Dice { get; set; }

        /// <summary>
        /// Get a percent between 01-100.
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// True (1) if ANY magic items. False(0) if specific magic items or no magic items.
        /// </summary>
        public bool AnyMagicItems { get; set; }

        /// <summary>
        /// The number of magic items of type ANY.
        /// </summary>
        public int NumberOfAnyMagicItems { get; set; }

        /// <summary>
        /// Magic items that exclude weapons.
        /// </summary>
        public bool ExceptWeapons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int NumberOfDice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MaxRollValue { get; set; }

        public Dictionary<MonsterTypes, List<string>> MagicItemTypes { get; set; }


        #endregion Properties

        /// <summary>
        /// Instanstiate MagicItemTreasure. Instantiate literally means "to create an instance of". In programming, this generally means to create an instance of an object.
        /// You do that by using a constructor. A constructor is a special method of a class that initializes an object of that class.
        /// Constructors have the same name as the class they're in, and because they always return an instance of that class, a return type isn't needed.
        /// </summary>
        /// <param name="percent">A number between 01-100.</param>
        /// <param name="anyMagicItems">If you roll on the table to get ANY type of magic item. Some treasure does not allow ANY type.</param>
        /// <param name="numberOfMagicItems">The Number of magic items in the treasure.</param>
        /// <param name="exceptWeapons">This does not allow any weapons (swords, other weapons) to be found in the treasure. All other items are okay.</param>
        /// <param name="magicItemsCompressed"></param>
        public MagicItemTreasure(double percent, bool anyMagicItems, int numberOfMagicItems, bool exceptWeapons, string magicItemsCompressed)//MagicItemTreasure constructor with arguements
        {    //double percent, bool anyMagicItems, int numberOfMagicItems, bool exceptWeapons, string magicItemsCompressed.
            Dice = Dice.D100;
            Percent = percent;
            AnyMagicItems = anyMagicItems;
            NumberOfAnyMagicItems = numberOfMagicItems;
            ExceptWeapons = exceptWeapons;
            if (magicItemsCompressed != "nil")
            {
            MagicItemTypes = DecompressedMagicItems(magicItemsCompressed);
            }
        }

        #region Private Methods
        private Dictionary<MonsterTypes, List<string>> DecompressedMagicItems(string magicItemsCompressed)
        {
            Dictionary<MonsterTypes, List<string>> magicItemTypes = new Dictionary<MonsterTypes, List<string>>();
            var magicItemsDecompressed = magicItemsCompressed.Split(':');
            foreach (var item in magicItemsDecompressed)
            {
                var magicItemMinMax = item.Split(',');
                MonsterTypes itemTypes = GetMagicItemTypes(magicItemMinMax[0]);
                var MinMax = new List<string>();
                MinMax.Add(magicItemMinMax[1]);
                if (magicItemMinMax.Count() > 2)
                {
                    MinMax.Add(magicItemMinMax[2]);
                }
                    magicItemTypes.Add(itemTypes, MinMax);
            }
            return magicItemTypes;
        }

        private MonsterTypes GetMagicItemTypes(string magicItemTypes)
        {

            return (MonsterTypes)Enum.Parse(typeof(MonsterTypes), magicItemTypes);
        }
        #endregion Private Methods
    }
}
