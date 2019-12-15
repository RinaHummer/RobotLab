using Robots.Cargos;

namespace Robots
{
    public class CyborgBackpack : Backpack
    {
        
        public CyborgBackpack() : base(1000) { }
        
        public override void AddCargo(Cargo cargo)
        {
            
            backpackList.Add(cargo);
            IncWeight(cargo.weight);
            IncCost(cargo.cost);
            isLastCargoDamaged = cargo is ToxicCargo ? true : false;
        }
    }
}
