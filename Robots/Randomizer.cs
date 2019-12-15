using System;

namespace Robots
{
    static class Randomizer
    {
        static public int GetRandomValue(int interval)
        {
            Random r = new Random();
            return r.Next(1, interval + 1);
        }
        static public bool GenerateChance(int chance)
        {
            int a = GetRandomValue(100);
            if (a < chance)
                return true;
            else
                return false;
        }
    }
}
