using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math=SampleProject.Fundamentals.Math;

namespace SampleProject.UnitTests.Fundamentals.Tests
{
    [TestFixture]
    public class MathTests
    {

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            //Arrange
            Math math = new Math();
            //Act
            var result = math.Add(1, 3);
            //Assert
            Assert.AreEqual(result, 4);
        }
    }
}
