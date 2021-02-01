using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitventureApp.util;

namespace APITestProject
{
    [TestClass]
    public class TestCase
    {
        [TestMethod]
        public void EvaluateName()
        {
            Evaluate Evaluate = new Evaluate();
            string sInput = "mpho nethathe";
            string sRegex = "mpho nethathe";
            Assert.AreEqual(Evaluate.EvaluateName(sInput, sRegex), true);

        }

        [TestMethod]
        public void EvaluateHeight()
        {
            Evaluate Evaluate = new Evaluate();
            string height = "172";
            Assert.AreEqual(Evaluate.EvaluateHeight(height), true);

        }

        //[TestMethod]
        //public void TestApiCall()
        //{
        //    Evaluate Evaluate = new Evaluate();
        //    string height = "172";
        //    Assert.AreEqual(Evaluate.EvaluateHeight(height), true);

        //}
    }
}
