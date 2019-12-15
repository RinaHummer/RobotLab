using System.Collections.Generic;

namespace Robots
{
    public abstract class Backpack
    {
        public int maxWeight { get; private set; }
        public int currWeight { get; private set; }
        public int currCost { get; private set; }
        public List<Cargo> backpackList = new List<Cargo>();
        public bool isLastCargoDamaged { get; protected set; }


        public Backpack(int maxWeight)
        {
            this.maxWeight = maxWeight;
            isLastCargoDamaged = false;

        }
        public void IncCost(int cost)
        {
            currCost += cost;
        }
        public void IncWeight(int weight)
        {
            currWeight += weight;
        }
        public abstract void AddCargo(Cargo cargo);

        public void RestoreState(RobotMemento state)
        {
            currWeight = state.currWeight;
            currCost = state.currCost;
            isLastCargoDamaged = state.isLastCargoDamaged;
            backpackList = state.backpackList;
        }
    }
}
