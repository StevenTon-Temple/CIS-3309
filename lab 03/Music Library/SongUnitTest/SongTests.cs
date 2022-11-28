using Microsoft.VisualStudio.TestTools.UnitTesting;
using SongClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongClassLibrary.Tests
{
    [TestClass()]
    public class SongTests
    {
        [TestMethod()]
        public void SongTest()
        {
            Song song = null;
            Assert.IsNull(song);

            song = new Song("Star Walkin'");
            Assert.IsNotNull(song); // can also use ->      Assert.AreNotEqual(null, song);

        }

        [TestMethod()]
        public void TitleTest()
        {
            Song song = new Song("Star Walkin'");

            //             (expected title, actual title)
            Assert.AreEqual(song.Title, "Star Walkin'");

            Song song2 = new Song("Love Lockdown");
            Console.WriteLine(song2.Title);
        }
    }
}