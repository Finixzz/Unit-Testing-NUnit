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
    public class CustomerControllerTests
    {

        [Test]
        public void GetCustomerById_IdEqualsToZero_ReturnsNotFoundInstance()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomerById(0);

            // Result can be NotFound object or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());

            // Ensures that result can only be NotFound object
            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomerById_IdIsNotEqualToZero_ReturnsOkInstance()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomerById(1);

            Assert.That(result, Is.TypeOf<Ok>());

        }
    }
}
