using System;
using System.Collections.Generic;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragons.ChartEngine.Charts
{
    public class GetCharts
    {
        #region Fields
        Services.OpenFile services = new Services.OpenFile();
        #endregion Fields

        public Dictionary<MonsterTypes, List<Treasure.MonetaryTreasure>> MonetaryTreasure = 
            new Dictionary<MonsterTypes, List<Treasure.MonetaryTreasure>>(); 

        public List<Treasure.JewelryValue> JewelryGPValueChart = new List<Treasure.JewelryValue>();// Just created a solution 

        public List<Treasure.GemValue> GemGPValueChart = new List<Treasure.GemValue>();//todo create a solution for this one. Use the jewelry value one from above as a template.

        public Dictionary<MonsterTypes, Treasure.MagicItemValue> MagicItemValue =
            new Dictionary<MonsterTypes, Treasure.MagicItemValue>();

        public GetCharts() 
        {
            GetMonetaryChart();
            GetJewelryValueChart();
            GetGemValueChart();
            GetMagicItemTreasureChart();
            
            //todo create magicitem object like the above ones.
            //todo finish populating the textfile.
            //todo create a method to populate the magic item.
        }

        #region Public Methods

        public void GetJewelryValueChart()
        {
            List<string> goldPieceValue = services.GetDataFile(@"Resources\JewelryValueData.txt");
            
            foreach (var item in goldPieceValue)
            {
                var firstJewelryValueData = item.Split(';');
                JewelryGPValueChart.Add(new Treasure.JewelryValue(firstJewelryValueData[0],
                    Int32.Parse(firstJewelryValueData[1]), 
                    Int32.Parse(firstJewelryValueData[2])));
            }
        }
        //todo create Methods (that will open the text file to get the data) for the Gem and MagicItem charts.
        //todo also create the text docs.
        public void GetGemValueChart()
        {
            List<string> goldPieceValue = services.GetDataFile(@"Resources\GemValueData.txt");
            foreach (var item in goldPieceValue)
            {
                var gemValueData = item.Split(';');
                GemGPValueChart.Add(new Treasure.GemValue(gemValueData[0],
                    Int32.Parse(gemValueData[1]), 
                    double.Parse(gemValueData[2]), 
                    double.Parse(gemValueData[3])));
            }
        }

        public void GetMagicItemTreasureChart()
        {
            List<string> magicItemValue = services.GetDataFile(@"C:\Users\Joseph\Desktop\DungeonsAndDragons.ChartEngine\DungeonsAndDragons.ChartEngine\DungeonsAndDragons.ChartEngine\Resources\MagicItemData.txt");
            foreach (var item in magicItemValue)
            {
                var magicItemData = item.Split(',');
                var firstAddress = magicItemData[0].Split(':');

                MonsterTypes monsterType = GetMonsterType(firstAddress[0]);
                double percentageOfMagicalTreasure = double.Parse(firstAddress[1]);
                bool isAny = magicItemData[1] == "1" ? true : false;
                int amountOfAny = Int32.Parse(magicItemData[2].ToString());
                string itemDetails = magicItemData[3].ToString();
                bool exceptWeapons = magicItemData[3] == "1" ? true : false;
                string magicItemsConpressed = magicItemData[4].ToString();
                 MagicItemValue.Add(monsterType, new Treasure.MagicItemValue(percentageOfMagicalTreasure, isAny, amountOfAny, itemDetails));
               // MagicItemValue.Add(monsterType, new Treasure.MagicItemTreasure(percentageOfMagicalTreasure, isAny, amountOfAny, exceptWeapons, magicItemsConpressed));

            }

        }
        /// <summary>
        /// Assignment 1)Fill in treaure chart. 2)Write description.
        /// </summary>
        public void GetMonetaryChart()
        {
            //todo create a foreach loop through each line of the text file

            List<string> monetaryChartData = services.GetDataFile();
            foreach (var treasurepiece in monetaryChartData)
            {           
                string firstMonetaryChartData = treasurepiece;
            var firstSplit = firstMonetaryChartData.Split(':');
            var monsterType = GetMonsterType(firstSplit[0]);
            var secondSplit = firstSplit[1].Split(';');
                MonetaryTreasure.Add(monsterType, PopulateMonetaryChart(secondSplit));
            }

        }
        /// <summary>
        /// Create the list of monetary treasure.
        /// </summary>
        /// <param name="secondSplit"></param>
        /// <returns></returns>
        public List<Treasure.MonetaryTreasure> PopulateMonetaryChart(string[] secondSplit)
        {
            var TreasureRewards = new List<Treasure.MonetaryTreasure>();
            foreach (var element in secondSplit)
            {
                var thirdSplit = element.Split(',');
                TreasureRewards.Add(new Treasure.MonetaryTreasure(thirdSplit[0], Int16.Parse(thirdSplit[1]), Int16.Parse(thirdSplit[2]),
                    Int16.Parse(thirdSplit[3]), double.Parse(thirdSplit[4])));
            }
            return TreasureRewards;
        }

        #endregion Public Methods


        #region Priviate Methods
        /// <summary>
        /// This gets the monster type of each monster.
        /// <example>A, B, P, etc.</example>
        /// </summary>
        /// <param name="monsterType"></param>
        /// <returns></returns>
        private MonsterTypes GetMonsterType(string monsterType)
        {

            return (MonsterTypes)Enum.Parse(typeof(MonsterTypes), monsterType);
        }
        #endregion Private Methods
    }
}
