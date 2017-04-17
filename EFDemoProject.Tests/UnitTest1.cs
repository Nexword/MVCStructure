using System;
using EFDemoProject.Infrastructure.Data.EF;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFDemoProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var issueHelper = new BugTrackerContext();
        }
    }
}
