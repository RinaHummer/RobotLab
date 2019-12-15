using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots;
using Robots.Cargos;

namespace RobotTests
{
    [TestClass]
    public class BackpackTests
    {
        [TestMethod]
        public void AddCargoTest()
        {
            Backpack backpack = new WorkerBackpack();
            Cargo cargo = new Cargo();

            backpack.AddCargo(cargo);

            Assert.AreEqual(cargo.weight, backpack.currWeight);
            Assert.AreEqual(cargo.cost, backpack.currCost);
            Assert.AreEqual(1, backpack.backpackList.Count);

        }
        [TestMethod]
        public void AddCargoForCyborgTest()
        {
            Backpack backpack = new CyborgBackpack();
            Cargo cargo = new Cargo();
            cargo = new ToxicCargo(cargo);

            backpack.AddCargo(cargo);


            Assert.AreEqual(true, backpack.isLastCargoDamaged);
            

        }
    }
}
