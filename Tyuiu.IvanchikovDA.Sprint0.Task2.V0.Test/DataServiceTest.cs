using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IvanchikovDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дима";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Дима", res);
        }
    }
}