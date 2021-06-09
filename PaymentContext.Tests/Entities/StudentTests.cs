using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Brian", "Bob");
            var document = new Document("35111507795", EDocumentType.CPF);
            var email = new Email("brianbob@london.com");
            var student = new Student(name, document, email);

            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadNoActiveSubscription()
        {
            Assert.Fail();
        }
    }
}