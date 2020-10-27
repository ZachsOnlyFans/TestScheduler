using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestScheduler.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestScheduler.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            bool test = true;
            if (username != null)
            {
                Assert.IsTrue(test);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}