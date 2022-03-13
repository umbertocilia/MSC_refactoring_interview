using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{


    public abstract class AbrstractCalculator : ICalculator
    {

        private Func<int, int, decimal> _disc = (amount, years) => (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
        public Func<int, int, decimal> disc
        {
            get { return _disc; }
            set { _disc = value; }
        }


        public abstract decimal Calculate(int amount, int years);

        public  void checkInput(int amount, int years)
        {
            if (amount < 0 || years < 0) throw new ArgumentException("Input values not valid, both must be greater than or equal to zero");
        }



    }

}
