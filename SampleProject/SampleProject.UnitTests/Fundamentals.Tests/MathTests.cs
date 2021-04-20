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
        private Math _math;

        //SetUp
        //TearDown

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            //Act
            var result = _math.Add(1, 2);
            //Assert
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstArgument()
        {

            var result = _math.Max(2, 1);

            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsTheSecondArgument()
        {

            var result = _math.Max(1, 2);

            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnsTheSameArguments()
        {

            var result = _math.Max(1, 1);

            Assert.AreEqual(result, 1);
        }

        //Parameterized tests
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreatherArgument(int a,int b,int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
