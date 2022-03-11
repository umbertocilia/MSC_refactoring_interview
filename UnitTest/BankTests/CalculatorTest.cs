using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorMSC;

namespace CalculatorTest
{
    [TestClass]
    public class CAlculatorTests
    {
        [TestMethod]
        public void Test1()
        {
            DiscountManager discManager = new DiscountManager();

            discManager.Add(Customer.Type.Unregistered, new UnregisteredDisc());
            discManager.Add(Customer.Type.Registered, new RegisteredDisc());
            discManager.Add(Customer.Type.Valuable, new ValuableDIsc());
            discManager.Add(Customer.Type.MostValuable, new MostValuableDisc());


            discManager.SetCalculator(Customer.Type.Unregistered);

            decimal result = discManager.GetCalculator().Calculate(10, 0);
            Assert.AreEqual(10, result, "Account not correct");
        }

       
    }
}
