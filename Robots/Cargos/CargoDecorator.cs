namespace Robots.Cargos
{
    public abstract class CargoDecorator : Cargo
    {
        protected Cargo cargo;
        public CargoDecorator(Cargo cargo) : base()
        {
            this.cargo = cargo;
        }
    }
}
