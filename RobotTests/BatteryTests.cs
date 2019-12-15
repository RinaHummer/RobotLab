using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots;
using Robots.Cargos;

namespace RobotTests
{
    [TestClass]
    public class BatteryTests
    {
        [TestInitialize] 
        
        [TestMethod]
        public void DecreaseBatteryLevelForWorkerAndSmarter_WithoutCargoTest()
        {
            Battery battery = new BatteryForWorker();
            Backpack backpack = new WorkerBackpack();

            double expectedRes = battery.currBatteryLevel - Battery.indexOfDecreasingAfterMove;
            battery.DecreaseBatteryLevel(backpack);

            Assert.AreEqual(expectedRes, battery.currBatteryLevel);
        }

        [TestMethod]
        public void DecreaseBatteryLevelForWorkerAndSmarter_WithCargoTest()
        {
            Battery battery = new BatteryForWorker();
            Backpack backpack = new WorkerBackpack();
            Cargo cargo = new Cargo();
            backpack.AddCargo(cargo);

            battery.DecreaseBatteryLevel(backpack);
            double expectedRes = battery.maxBatteryLevel - Battery.indexOfDecreasingAfterMove - cargo.weight * Battery.indexOfDecreasing;

            Assert.AreEqual(expectedRes, battery.currBatteryLevel);
        }
        [TestMethod]
        public void DecreaseBatteryLevelForCyborg_ToxicCargoTest()
        {
            Battery battery = new BatteryForCyborg();
            Backpack backpack = new CyborgBackpack();
            ToxicCargo cargo = new ToxicCargo(new Cargo());
            backpack.AddCargo(cargo);

            double expectedRes = battery.currBatteryLevel - Battery.indexOfDecreasingAfterMove - cargo.Damage() - cargo.weight * Battery.indexOfDecreasing; ;
            battery.DecreaseBatteryLevel(backpack);

            Assert.AreEqual(expectedRes, battery.currBatteryLevel);
        }

    }
}
