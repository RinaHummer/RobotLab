namespace Robots
{
    public class SmarterBackpack : Backpack
    {
        public SmarterBackpack(): base(700) { }

        public override void AddCargo(Cargo cargo)
        {
            backpackList.Add(cargo);
            IncWeight(cargo.weight);
            IncCost(cargo.cost);
        }
    }
}
