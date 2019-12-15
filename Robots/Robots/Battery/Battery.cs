namespace Robots
{
    abstract public class Battery
    {
        public const double indexOfDecreasing = 0.3;
        public const int indexOfDecreasingAfterMove = 5;
        public double maxBatteryLevel { get; private set; } 
        public double currBatteryLevel { get; protected set; } 
        public Battery(int maxBatteryLevel)
        {
            this.maxBatteryLevel = maxBatteryLevel;
            currBatteryLevel = maxBatteryLevel;
        }
        public abstract string GetBatteryInfo();
        public abstract void DecreaseBatteryLevel(Backpack b);
        

        public bool CheckIsDead()
        {
            if (currBatteryLevel <= 0)
            {
                return true;
            }
            return false;
        }
        public void RestoreState(RobotMemento state)
        {
            currBatteryLevel = state.currBatteryLevel;
        }
    }
}
