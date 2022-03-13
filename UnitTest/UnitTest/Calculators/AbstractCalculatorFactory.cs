using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{

    public abstract class AbstractDiscount
    {
        public abstract ICalculator GetCalculator();
        public abstract void SetCalculator(Customer.Type type);
    }

}
