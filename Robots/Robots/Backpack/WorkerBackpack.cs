namespace Robots
{
    public class WorkerBackpack : Backpack
    {
        public WorkerBackpack() : base(1000) { }

        public override void AddCargo(Cargo cargo)
        {
            backpackList.Add(cargo);
            IncWeight(cargo.weight);
            IncCost(cargo.cost);
        }
    }
}
