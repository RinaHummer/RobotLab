using Robots.Cargos;
using System.Linq;

namespace Robots
{
    public class BatteryForCyborg : Battery
    {
        public BatteryForCyborg() : base(100) { }
        public override string GetBatteryInfo()
        {
            return "Standard Battery for Cyborgs PT009001";
        }
        public override void DecreaseBatteryLevel(Backpack b)
        {
            if (GetSick(b))
            {
                currBatteryLevel = 0;
                return;
            } else if (b.isLastCargoDamaged)
            {
                ToxicCargo c = (ToxicCargo)b.backpackList.Last();
                currBatteryLevel = currBatteryLevel - c.Damage() - indexOfDecreasingAfterMove - b.currWeight * indexOfDecreasing;
            } else 
            {
                currBatteryLevel = currBatteryLevel - indexOfDecreasingAfterMove - b.currWeight * indexOfDecreasing;
            } 
        }

        
        public bool GetSick(Backpack b)
        {
            if (b.currWeight >= 800 && Randomizer.GenerateChance(30))
            {
                return true;
            }
            return false;
        } 
    }
}
