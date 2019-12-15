namespace Robots.Cargos
{
    public class ToxicCargo : CargoDecorator
    {
        
        public ToxicCargo(Cargo cargo) : base(cargo)
        {
            this.name += " токсичен";
            this.cargo = cargo;
        }

        public int Damage()
        {
            return Randomizer.GetRandomValue(30);
        }
    }
}

