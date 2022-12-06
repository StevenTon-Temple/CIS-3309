using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void GetPointTest()
        {
            Game game = new Game();
            game.GetPoint("50");
            int test = 25;
            Assert.AreNotEqual(test, game.GetPoint("50"));
            game.GetPoint("4");
            int test1 = 75;
            Assert.AreNotEqual(test1, game.GetPoint("4"));
            game.GetPoint("1000");
            int test2 = 125;
            Assert.AreNotEqual(test2, game.GetPoint("1000"));
            game.GetPoint("500");
            int test3 = 500;
            Assert.AreEqual(test3, game.GetPoint("500"));
            game.GetPoint("400");
            int test4 = 400;
            Assert.AreEqual(test4, game.GetPoint("400"));
            game.GetPoint("300");
            int test5 = 300;
            Assert.AreEqual(test5, game.GetPoint("300"));

            //Assert.Fail();
        }
    }
}