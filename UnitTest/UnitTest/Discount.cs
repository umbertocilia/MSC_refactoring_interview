using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{
    

    public class Discount : AbstractDiscount
    {

        private Dictionary<Customer.Type, ICalculator> calcDict= new Dictionary<Customer.Type, ICalculator>();

        private ICalculator calculator;


        public Discount() { }

        public void Add(Customer.Type customerType, ICalculator calcClass)
        {
            calcDict.Add(customerType, calcClass);
        }


        public override  void SetCalculator(Customer.Type type)
        {
            if (!calcDict.ContainsKey(type)) throw  new NotImplementedException("Calculator rules not set");
            calculator = calcDict[type];
        }

     

        public override ICalculator GetCalculator()
        {
            return calculator;
        }
    }


}
