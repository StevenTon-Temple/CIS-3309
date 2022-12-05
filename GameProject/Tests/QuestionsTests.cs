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
    public class QuestionsTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            Questions question = new Questions();
            question.Category = "Sport";
            string test = "History";
            Assert.AreNotEqual(test, question.Category = "Sport");
            question.Category = "History";
            string test1 = "Math";
            Assert.AreNotEqual(test1, question.Category = "History");
            question.Category = "Science";
            string test2 = "History";
            Assert.AreNotEqual(test2, question.Category = "Science");
            question.Category = "Geography";
            string test3 = "Science";
            Assert.AreNotEqual(test3, question.Category = "Geography");
            question.Category = "Science";
            string test4 = "Science";
            Assert.AreEqual(test4, question.Category = "Science");
            question.Category = "Math";
            string test5 = "Math";
            Assert.AreEqual(test5, question.Category = "Math");
            question.Category = "Geography";
            string test6 = "Geography";
            Assert.AreEqual(test6, question.Category = "Geography");
        }
    }
}