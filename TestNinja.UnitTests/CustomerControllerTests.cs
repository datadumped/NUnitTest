using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            // NotFound object
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of the derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());

        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            // NotFound object
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
