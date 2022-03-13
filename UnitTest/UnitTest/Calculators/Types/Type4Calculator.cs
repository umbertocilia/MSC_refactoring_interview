using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{

    public class Type4Calculator : AbrstractCalculator
    {
        public Type4Calculator() { }

        public override decimal Calculate(int amount, int years)
        {
            checkInput(amount, years);
            return (amount - (0.5m * amount)) - disc(amount, years) * (amount - (0.5m * amount));
        }
    }
}
