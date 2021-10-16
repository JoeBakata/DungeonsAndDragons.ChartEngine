using DungeonsAndDragons.ChartEngine.Utilities;

namespace DungeonsAndDragons.ChartEngine.Services
{
    public class LogicRepository
    {
        public bool PercentageRoll(string gem)
        {
            int randomNumber = RandomNumberGenerator.NumberBetween(1, 100);
            switch (gem)
            {
                case "Quartz":
                    if (randomNumber <= 20)
                        return true;
                    break;

            }


            return false;
        }

        public bool PercentageRoll(MonsterTypes monsterTypes)
        {
            var percent = GetPercent(monsterTypes);
            if (percent == 0)
            {
                return false;
            }
            int randomNumber = RandomNumberGenerator.NumberBetween(1, 100);
            return (percent >= randomNumber) ? true: false;
        }

        private int GetPercent(MonsterTypes monsterType)
        {
            switch (monsterType)
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
    }
}
