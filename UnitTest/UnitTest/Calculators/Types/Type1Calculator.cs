using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{
    /// <summary>
    /// No discount applied
    /// </summary>
    public class Type1Calculator : AbrstractCalculator
    {
        public Type1Calculator() { }


        public override decimal Calculate(int amount, int years)
        {
            checkInput(amount, years);
            return amount;
        }
    }
}
