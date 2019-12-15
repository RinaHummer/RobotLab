namespace Robots.Cargos
{
    public class EncodedCargo : CargoDecorator
    {
        public EncodedCargo(Cargo cargo) : base(cargo)
        {
            this.name += " закодирован";
            this.cargo = cargo;
            needDecoding = true;
        }

    }
}
