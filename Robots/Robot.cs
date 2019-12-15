using Robots.Robots.Decoding;

namespace Robots
{
     class Robot
    {
        public string name { get; private set; }
        public Backpack backpack { get; private set; }
        public DecoderSkill decoder { get; private set; }
        public Battery battery { get; private set; }
        

        public Robot(RobotFactory factory)
        {
            name = factory.SetName();
            backpack = factory.SetBackpack();
            decoder = factory.SetDecoder();
            battery = factory.SetBattery();
        }   
        public void Move()
        {
            battery.DecreaseBatteryLevel(backpack);
        }
        
        public RobotMemento SaveState()
        {
            return new RobotMemento(battery, backpack);
        }

        public void RestoreState(RobotMemento state)
        {
            battery.RestoreState(state);
            backpack.RestoreState(state);
        }
        

    }
}
