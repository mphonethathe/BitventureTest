using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitventureApp.util;
using System.Net.Http;
using BitventureApp.Service.swapi;

namespace APITestProject
{
    [TestClass]
    public class TestCase
    {
        Evaluate Evaluate = new Evaluate();

        [TestMethod]
        public void EvaluateName()
        {

           string sInput = "Luke Skywalker";
            string sRegex = "Luke Skywalker";
            Assert.AreEqual(Evaluate.EvaluateName(sInput, sRegex), true);

        }

        [TestMethod]
        public void EvaluateHeight()
        {
            string height = "172";
            Assert.AreEqual(Evaluate.EvaluateHeight(height), true);

        }

        [TestMethod]
        public void TestApiCall()
        {

            HttpClient _httpClient = new HttpClient();
            SwapiService SwapiService = new SwapiService(_httpClient);

           
            Assert.IsNotNull(SwapiService.GetPeople());

        }

        [TestMethod]
        public void EvaluateEmail()
        {
            string email = "mphonethathe@gmail.com";
            Assert.AreEqual(Evaluate.EvaluateEmail(email), true);

        }
    }
}
