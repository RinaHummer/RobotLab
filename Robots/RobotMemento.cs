using System.Collections.Generic;

namespace Robots
{
    public class RobotMemento
    {
        public int currWeight { get; private set; }
        public int currCost { get; private set; }
        public List<Cargo> backpackList { get; private set; }
        public double currBatteryLevel { get; private set; }
        public bool isLastCargoDamaged { get; private set; }
        public RobotMemento(Battery b, Backpack p)
        {
            currBatteryLevel = b.currBatteryLevel;
            currCost = p.currCost;
            currWeight = p.currWeight;
            isLastCargoDamaged = p.isLastCargoDamaged;
            backpackList = new List<Cargo>(p.backpackList);
        }
    }
}
