using Robots.Robots.Decoding;

namespace Robots
{
    abstract class RobotFactory
    {
        public abstract Battery SetBattery();
        public abstract Backpack SetBackpack();
        public abstract DecoderSkill SetDecoder();
        public abstract string SetName();
    }
}
