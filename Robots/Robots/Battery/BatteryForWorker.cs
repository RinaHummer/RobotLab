namespace Robots
{
    public class BatteryForWorker : Battery
    {
        public BatteryForWorker() : base(150) { }
        public override string GetBatteryInfo()
        {
            return "SuperBattery for Workers +50% extra charge! PR333999";
        }
        public override void DecreaseBatteryLevel(Backpack b)
        {
            currBatteryLevel = currBatteryLevel - indexOfDecreasingAfterMove - b.currWeight * indexOfDecreasing;
        }

    }
}
