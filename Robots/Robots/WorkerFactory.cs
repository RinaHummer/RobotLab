using Robots.Robots.Decoding;

namespace Robots
{
    class WorkerFactory : RobotFactory
    {
        public override string SetName()
        {
            return "Worker A00000";
        }

        public override Battery SetBattery()
        {
            return new BatteryForWorker();
        }

        public override Backpack SetBackpack()
        {
            return new WorkerBackpack();
        }
        public override DecoderSkill SetDecoder()
        {
            return new BadDecoder();
        }
    }
}
