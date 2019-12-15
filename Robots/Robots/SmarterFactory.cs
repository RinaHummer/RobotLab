using Robots.Robots.Decoding;

namespace Robots
{
    class SmarterFactory : RobotFactory
    {
        public override string SetName()
        {
            return "Smarte L666";
        }

        public override Battery SetBattery()
        {
            return new BatteryForSmarter();
        }

        public override Backpack SetBackpack()
        {
            return new CyborgBackpack();
        }
        public override DecoderSkill SetDecoder()
        {
            return new SmartDecoder();
        }
    }
}
