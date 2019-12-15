using System.Collections.Generic;

namespace Robots
{
    class GameHistory
    {
        public Stack<RobotMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<RobotMemento>();
        }
    }
}
