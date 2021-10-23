using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Services
{
    public class LogicRepository
    {
        private int Min;// This is a field. A field is a variable of any type that is declared directly in the class
        private int Max;

        public string NumberRolled { get; set; }
        public int Quartz { get; set; }
        public int Turquoise { get; set; }
        public int Citrine { get; set; }
        public int Onyx { get; set; }
        public int Amber { get; set; }
        public int Garnet { get; set; }
        public int Pearl { get; set; }
        public int Topaz { get; set; }
        public int Opal { get; set; }
        public int Ruby { get; set; }


        public bool PercentageRoll(MonsterTypes monsterTypes)
        {
            var percent = GetPercent(monsterTypes);
            if (percent == 0)
            {
                return false;
            }
            int randomNumber = RandomNumberGenerator.NumberBetween(1, 100);
            NumberRolled = randomNumber.ToString();
            return (percent >= randomNumber) ? true : false;
        }

        public string GetNumberOfGems(MonsterTypes monsterTypes)
        {
            _GetNumberOfGems(monsterTypes);
            int randomNumber = RandomNumberGenerator.NumberBetween(Min, Max);
            return randomNumber.ToString();
        }

        public void GetGemNumbers(string _numberOfGems)
        {
            Reset();
            int numberOfGems = int.Parse(_numberOfGems);
            for (int i = 0; i < numberOfGems; i++)
            {
                int randomNumber = RandomNumberGenerator.NumberBetween(1, 100);
                IncreaseGem(randomNumber);
            }
        }

        private void IncreaseGem(int randomNumber)
        {
            int coinFlip = RandomNumberGenerator.NumberBetween(1, 2);
            if (randomNumber >= 1 && randomNumber <= 20)
            {
                if (coinFlip == 1)
                {
                    Quartz++;
                }
                else
                {
                    Turquoise++;
                }
            }
            else if (randomNumber >= 21 && randomNumber <= 45)
            {
                if (coinFlip == 1)
                {
                    Citrine++;
                }
                else
                {
                    Onyx++;
                }
            }
            else if (randomNumber >= 46 && randomNumber <= 75)
            {
                if (coinFlip == 1)
                {
                    Amber++;
                }
                else
                {
                    Garnet++;
                }
            }
            else if (randomNumber >= 76 && randomNumber <= 95)
            {
                if (coinFlip == 1)
                {
                    Pearl++;
                }
                else
                {
                    Topaz++;
                }
            }
            else
            {
                if (coinFlip == 1)
                {
                    Opal++;
                }
                else
                {
                    Ruby++;
                }
            } 
        }
        private void Reset()
        {
            Quartz = 0;
            Turquoise = 0;
            Citrine = 0;
            Onyx = 0;
            Amber = 0;
            Garnet = 0;
            Pearl = 0;
            Topaz = 0;
            Opal = 0;
            Ruby = 0;
        }
        private int GetPercent(MonsterTypes monsterTypes)
        {
            switch (monsterTypes)
            {
                case MonsterTypes.A:
                case MonsterTypes.H:
                case MonsterTypes.I:
                case MonsterTypes.L:
                    return 50;
                case MonsterTypes.B:
                case MonsterTypes.C:
                case MonsterTypes.G:
                    return 25;
                case MonsterTypes.D:
                    return 30;
                case MonsterTypes.E:
                    return 10;
                case MonsterTypes.F:
                    return 20;
                case MonsterTypes.J:
                case MonsterTypes.K:
                case MonsterTypes.N:
                case MonsterTypes.O:
                case MonsterTypes.P:
                case MonsterTypes.Q:
                case MonsterTypes.R:
                case MonsterTypes.S:
                case MonsterTypes.T:
                case MonsterTypes.U:
                case MonsterTypes.V:
                    return 0;
                case MonsterTypes.M:
                    return 55;
            }
            return 0;
        }

        private void _GetNumberOfGems(MonsterTypes monsterTypes)
        {
            switch (monsterTypes)
            {
                case MonsterTypes.A:
                    Min = 6;
                    Max = 36;
                    break;
                case MonsterTypes.B:
                    Min = 1;
                    Max = 6;
                    break;
                case MonsterTypes.C:
                    Min = 1;
                    Max = 4;
                    break;
                case MonsterTypes.D:
                    Min = 1;
                    Max = 8;
                    break;
                case MonsterTypes.E:
                    Min = 1;
                    Max = 10;
                    break;
                case MonsterTypes.F:
                    Min = 2;
                    Max = 24;
                    break;
                case MonsterTypes.G:
                    Min = 3;
                    Max = 18;
                    break;
                case MonsterTypes.H:
                    Min = 1;
                    Max = 100;
                    break;
                case MonsterTypes.I:
                    Min = 2;
                    Max = 12;
                    break;
                case MonsterTypes.L:
                    Min = 1;
                    Max = 4;
                    break;
                case MonsterTypes.M:
                    Min = 5;
                    Max = 20;
                    break;
                case MonsterTypes.J:
                case MonsterTypes.K:
                case MonsterTypes.N:
                case MonsterTypes.O:
                case MonsterTypes.P:
                case MonsterTypes.Q:
                case MonsterTypes.R:
                case MonsterTypes.S:
                case MonsterTypes.T:
                case MonsterTypes.U:
                case MonsterTypes.V:
                    Min = 0;
                    Max = 0;
                    break;
            }
        }
    }
}
