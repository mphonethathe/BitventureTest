
using BitventureApp.util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Test1()
        {

            Evaluate evaluate = new Evaluate();
            Assert.AreEqual(evaluate.EvaluateName("",""),"groot");
        }
    }
}