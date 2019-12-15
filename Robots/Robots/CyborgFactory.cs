using Robots.Robots.Decoding;

namespace Robots
{
    class CyborgFactory : RobotFactory
    {
        

        public override Battery SetBattery()
        {
            return new BatteryForCyborg();
        }

        public override Backpack SetBackpack()
        {
            return new CyborgBackpack();
        }

        public override DecoderSkill SetDecoder()
        {
            return new OrdinaryDecoder();
        }

        public override string SetName()
        {
            return "Cyborg TH290";
        }
    }
}
