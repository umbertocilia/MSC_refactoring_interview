using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{

    public class Type3Calculator : AbrstractCalculator
    {
        public Type3Calculator() { }

        public override decimal Calculate(int amount, int years)
        {
            checkInput(amount, years);
            return (0.7m * amount) - disc(amount, years) * (0.7m * amount);
        }
    }
}
