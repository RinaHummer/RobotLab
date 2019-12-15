namespace Robots
{
    public class Cargo
    {
        private const int maxWeight = 200;
        private const int maxCost = 200;
        public string name { get; protected set; }

        public int weight { get; private set; }
        public int cost { get; private set; }
        public bool needDecoding = false;

        public Cargo()
        {
            name = "Груз";
            weight = Randomizer.GetRandomValue(200);
            cost = Randomizer.GetRandomValue(1000);
        }     
        
    }
}
