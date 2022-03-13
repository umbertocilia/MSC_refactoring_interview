using CalculatorMSC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CAlculatorTests
    {
        [TestMethod]
        public void ArgumentExceptionTest()
        {
            Discount disc = new Discount();

            disc.Add(Customer.Type.Unregistered, new Type1Calculator());
            disc.Add(Customer.Type.Registered, new Type2Calculator());
            disc.Add(Customer.Type.Valuable, new Type3Calculator());
            disc.Add(Customer.Type.MostValuable, new Type4Calculator());


            disc.SetCalculator(Customer.Type.Valuable);

            Assert.ThrowsException<ArgumentException>(() => disc.GetCalculator().Calculate(-10, -20));
        }


        [TestMethod]
        public void NotImplementedTest()
        {
            Discount disc = new Discount();
            Assert.ThrowsException<NotImplementedException>(() => disc.SetCalculator(Customer.Type.Valuable));
        }

        [TestMethod]
        public void UnregisteredCustomerTest()
        {
            Discount disc = new Discount();

            disc.Add(Customer.Type.Unregistered, new Type1Calculator());
            disc.Add(Customer.Type.Registered, new Type2Calculator());
            disc.Add(Customer.Type.Valuable, new Type3Calculator());
            disc.Add(Customer.Type.MostValuable, new Type4Calculator());


            disc.SetCalculator(Customer.Type.Unregistered);

            decimal result = disc.GetCalculator().Calculate(10, 20);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CalculatorAlreadySetTest()
        {
            Discount disc = new Discount();

            disc.Add(Customer.Type.Unregistered, new Type1Calculator());
            disc.Add(Customer.Type.Registered, new Type2Calculator());
            disc.Add(Customer.Type.Valuable, new Type3Calculator());
            disc.Add(Customer.Type.MostValuable, new Type4Calculator());

            Assert.ThrowsException<ArgumentException>(() => disc.Add(Customer.Type.MostValuable, new Type4Calculator()));
        }


    }
}

