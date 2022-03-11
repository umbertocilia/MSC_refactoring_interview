using System;
using System.Collections.Generic;

namespace CalculatorMSC
{

    public class Calculator
    {


        public static void Main()
        {

            DiscountManager discManager = new DiscountManager();

            discManager.Add(Customer.Type.Unregistered, new UnregisteredDisc());
            discManager.Add(Customer.Type.Registered, new RegisteredDisc());
            discManager.Add(Customer.Type.Valuable, new ValuableDIsc());
            discManager.Add(Customer.Type.MostValuable, new MostValuableDisc());


            discManager.SetCalculator(Customer.Type.Unregistered);

            decimal result = discManager.GetCalculator().Calculate(10, 20);
        }


    }



}

