using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void TestMethod1()
        {
            var testObject = new WebScraper.Utils.Clients.CustomWebBrowser();

            var result = await testObject.GetDocumentAsync("www.google.com");
            bool a = true;
            Assert.IsTrue(a);
        }
    }
}
