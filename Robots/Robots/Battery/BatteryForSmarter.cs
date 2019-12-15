namespace Robots
{
    public class BatteryForSmarter : Battery
    {
        public BatteryForSmarter() : base(100) { }
        public override string GetBatteryInfo()
        {
            return "Standart Battery for Smarters PS003223";
        }
        public override void DecreaseBatteryLevel(Backpack b)
        {
            currBatteryLevel = currBatteryLevel - indexOfDecreasingAfterMove - b.currWeight * indexOfDecreasing;
        }

    }
}
