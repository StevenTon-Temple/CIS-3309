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
    public class PlayersTests
    {
        [TestMethod()]
        public void Update_scoreTest()
        {
            Players player = new Players();
            player.Update_score(50, 50);
            int test = 100;
            //Assert.AreNotEqual(test, player.Update_score(50, 50));
        }

        [TestMethod()]
        public void Update_scoreTest1()
        {
            Assert.Fail();
        }
    }
}