using NUnit.Framework;
using SampleProject.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.UnitTests.Fundamentals.Tests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_ShouldSetLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("error");

            Assert.That(logger.LastError, Is.EqualTo("error"));
        }
    }
}
