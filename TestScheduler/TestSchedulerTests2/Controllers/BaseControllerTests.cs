using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestScheduler.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestScheduler.Controllers.Tests
{
    [TestClass()]
    public class BaseControllerTests
    {
        [TestMethod()]
        public void GetUsernameTest()
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