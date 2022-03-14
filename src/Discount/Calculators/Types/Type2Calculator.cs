using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{

    public class Type2Calculator : AbrstractCalculator
    {

        public Type2Calculator() { }

        public override decimal Calculate(int amount, int years)
        {
            checkInput(amount, years);
            return (amount - (0.1m * amount)) - disc(amount, years) * (amount - (0.1m * amount));
        }
    }
}
