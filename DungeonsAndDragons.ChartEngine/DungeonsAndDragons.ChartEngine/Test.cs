using System;

namespace DungeonsAndDragons.ChartEngine
{
    class Test
    {
        /// <summary>
        /// Display everything in monetary chart.
        /// </summary>
        public static void Main()
        {
            Charts.GetCharts FirstTest;

            FirstTest = new Charts.GetCharts();

            //FirstTest.GetJewelryValueChart();

            //foreach (var item in FirstTest.JewelryGPValueChart)
            //{
            //    Console.WriteLine($"Here is the {item.JewelryType}");
            //    Console.WriteLine($"It is worth {item.MinimumGPValue} at minimum");
            //    Console.WriteLine($"Could be worth {item.MaximumGPValue}");
            //}
            //FirstTest.GetMonetaryChart();


            //foreach (var item in FirstTest.MonetaryTreasure)
            //{
            //    Console.WriteLine($"MonsterType {item.Key}");

            //    foreach (var loot in item.Value)
            //    {
            //        Console.WriteLine($"   Treasure Name: {loot.TreasureName}");
            //        Console.WriteLine($"   Treasure Amount: {loot.TreasureAmount}");
            //        Console.WriteLine($"   Dice {loot.Dice}");
            //        Console.WriteLine($"   Percent: {loot.Percent}");
            //        Console.WriteLine($"   Max Roll Value: {loot.MaxRollValue}");
            //        Console.WriteLine($"   Number Of Dice: {loot.NumberOfDice}");
            //    }
            //}

            // Display gems.
            //foreach (var item in FirstTest.GemGPValueChart)
            //{

            //    Console.WriteLine($"gemtype {item.GemType}");
            //    Console.WriteLine($"minimumGPValue {item.MinimumGPValue}");
            //    Console.WriteLine($"minimumRollValue {item.MinimumRollValue}");
            //    Console.WriteLine($"maximumRollValue {item.MaximumRollValue}");
            //    Console.WriteLine($"dice {item.Dice}");
            //    Console.WriteLine($" --- ----");
            //}

            //// Display Jewelry chart.
            //foreach (var item in FirstTest.JewelryGPValueChart)
            //{
            //    Console.WriteLine($"jewelryType {item.JewelryType}");
            //    Console.WriteLine($"minimumGPValue {item.MinimumGPValue}");
            //    Console.WriteLine($"maximumGPValue {item.MaximumGPValue}");
            //    Console.WriteLine($" ---- ----");
            //}

            // Display Magic Item chart.
            foreach (var item in FirstTest.MagicItemValue)
            {
                Console.WriteLine($"monsterType {item.Key}");
                Console.WriteLine($"dice {item.Value.Dice}");
                Console.WriteLine($"magicItemTypes {item.Value.MagicItemTypes}");
                Console.WriteLine($"minimumRollValue {item.Value.MinimumRollValue}");
                Console.WriteLine($"maximumRollValue {item.Value.MaximumRollValue}");
                Console.WriteLine($"magicItemSubtableName {item.Value.MagicItemSubtableName}");
                Console.WriteLine($"--- -----");
            }

            //// Display Monetary Treasure chart.
            //foreach (var item in FirstTest.MonetaryTreasure)
            //{
            //    Console.WriteLine($"monsterType {item.Key}");
            //    foreach (var money in item.Value)
            //    {
            //        Console.WriteLine($"treasureName {money.TreasureName}");
            //        Console.WriteLine($"dice {money.Dice}");
            //        Console.WriteLine($"treasureAmount {money.TreasureAmount}");
            //        Console.WriteLine($"percent {money.Percent}");
            //        Console.WriteLine($"numberOfDice {money.NumberOfDice}");
            //        Console.WriteLine($"maxRollValue {money.MaxRollValue}");
            //        Console.WriteLine($"----  -----");
            //    }                           
            //}


            Console.ReadLine();
        }
    }

}
