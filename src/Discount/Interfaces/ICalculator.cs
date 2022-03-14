using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{
    public interface ICalculator
    {
        decimal Calculate(int amount, int years);
    }
}
