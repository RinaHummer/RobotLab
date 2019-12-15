using Robots.Cargos;

namespace Robots
{
     class Game
    {
        private const int chanceOfGettingSmarter = 20;
        private const int chanceOfGettingCyborg = 30;

        public string player { get; private set; }
        public Robot robot { get; private set; }
        public Cargo currCargo { get; private set; }
        public void SetPlayerName(string name)
        {
            if (name.Length <= 10)
                player = name;
        }
        
        public void SetRobot()
        {
            if(Randomizer.GenerateChance(chanceOfGettingSmarter))
            {
                robot = new Robot(new SmarterFactory());
            } else if (Randomizer.GenerateChance(chanceOfGettingCyborg))
            {
                robot = new Robot(new CyborgFactory());
            } else
            {
                robot = new Robot(new WorkerFactory());
            }         
        }
        
        public string GetRobotInfo()
        {
            return robot.name;
        }
        public string GetbatteryState()
        {
            return $"Battery info: {robot.battery.GetBatteryInfo()}, current battery level: {robot.battery.currBatteryLevel.ToString()}";
        }
        public bool IsOver()
        {
            if(robot.battery.CheckIsDead())
                return true;
            else
                return false;
        }
        public Cargo CreateCargo()
        {
            Cargo cargo = new Cargo();
            if(Randomizer.GenerateChance(40))
                cargo = new EncodedCargo(cargo);
            if (Randomizer.GenerateChance(20))
                cargo = new ToxicCargo(cargo);
            return cargo;   
        }
        public bool FindCargo()
        {
            if (Randomizer.GenerateChance(80))
            {
                currCargo = CreateCargo();
                return true;
            }
            return false;
        }
        public bool TakeCargo(Cargo cargo)
        {
            if (cargo.needDecoding)
            {
                if(robot.decoder.IsDecodingSuccessful())
                {
                    robot.backpack.AddCargo(cargo);
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                robot.backpack.AddCargo(cargo);
                return true;
            }
            
        }
        
    }
}
