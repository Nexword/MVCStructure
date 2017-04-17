using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using EFDemoProject.Domain.Core.Entities;
using EFDemoProject.Domain.Core.Enums;
using EFDemoProject.Domain.Interfaces;
using EFDemoProject.Infrastructure.Business;
using EFDemoProject.Infrastructure.Data.EF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EFDemoProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IssueHelper GetIssueHelper()
        {
            // Arrange
            Mock<IIssueRepository> mock = new Mock<IIssueRepository>();
            mock.Setup(m => m.Issues).Returns(new Issue[]
            {
                new Issue { Status = IssueStatuses.Open },
                new Issue { Status = IssueStatuses.Closed },
                new Issue { Status = IssueStatuses.Open},
                new Issue { Status = (IssueStatuses)255 },
                new Issue { Status = IssueStatuses.CodeReview },
                new Issue { Status = IssueStatuses.Closed }
            }.AsQueryable());

            return new IssueHelper(mock.Object);
        }

        [TestMethod]
        public void Test_GetIssueInCurrentStatus_Method()
        {
            //Act
            var issueHelper = GetIssueHelper();

           var count =  issueHelper.GetIssueCountInCurrentStatus((byte)IssueStatuses.Closed);

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Test_HaveOpenIssue_Method()
        {
            //Arrange
            Mock<IIssueRepository> mock = new Mock<IIssueRepository>();
            mock.Setup(m => m.Issues).Returns(new Issue[]
            {
                new Issue { Status = IssueStatuses.Open },
                new Issue { Status = IssueStatuses.Closed },
                new Issue { Status = IssueStatuses.Open},
                new Issue { Status = (IssueStatuses)255 },
                new Issue { Status = IssueStatuses.CodeReview },
                new Issue { Status = IssueStatuses.Closed }
            }.AsQueryable());
            
            //Act
            var issueHelper = new IssueHelper(mock.Object);

            //Assert
            Assert.AreEqual(true, issueHelper.HaveOpenIssues);          
        }
    }
}
