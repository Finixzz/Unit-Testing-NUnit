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
    public class HtmlFormatterTests
    {
        private HtmlFormatter _formatter;

        [SetUp]
        public void SetUp()
        {
            _formatter = new HtmlFormatter();
        }

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var result=_formatter.FormatAsBold("abc");

            // Specific
            // Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            // Assert.AreEqual(result, "<strong>abc</strong>");

            // More general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
            
            
        }
    }
}
