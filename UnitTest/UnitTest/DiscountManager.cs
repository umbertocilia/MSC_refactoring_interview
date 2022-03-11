using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMSC
{
    


    public class DiscountManager : AbstractCalculatorFactory
    {

        private Dictionary<Customer.Type, ICalculator> _list = new Dictionary<Customer.Type, ICalculator>();

        private ICalculator _calculator;


        public DiscountManager() { }

        public void Add(Customer.Type customerType, ICalculator calcClass)
        {
            _list.Add(customerType, calcClass);
        }


        public override  void SetCalculator(Customer.Type type)
        {
            _calculator = _list[type];
        }

     

        public override ICalculator GetCalculator()
        {
            return _calculator;
        }
    }





    public abstract class AbrstractCalculator : ICalculator
    {

        private Func<int, int, decimal> _disc = (amount, years) => (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
        public Func<int, int, decimal> disc
        {
            get { return _disc; }
            set { _disc = value; }
        }


        public abstract decimal Calculate(int amount, int years);
        

       
    }




    public abstract class AbstractCalculatorFactory
    {
        public abstract  ICalculator GetCalculator();
        public abstract void SetCalculator(Customer.Type type);
    }




    public class UnregisteredDisc : AbrstractCalculator
    {
        public UnregisteredDisc() { }


        public override decimal Calculate(int amount, int years)
        {
            return amount;
        }
    }

    public class RegisteredDisc : AbrstractCalculator
    {

        public RegisteredDisc() { }

        public override decimal Calculate(int amount, int years)
        {
           
            return (amount - (0.1m * amount)) - disc(amount,years) * (amount - (0.1m * amount));
        }
    }

    public class ValuableDIsc : AbrstractCalculator
    {
        public ValuableDIsc() { }

        public override decimal Calculate(int amount, int years)
        {
            return (0.7m * amount) - disc(amount, years) * (0.7m * amount);
        }
    }

    public class MostValuableDisc : AbrstractCalculator
    {
        public MostValuableDisc() { }

        public override decimal Calculate(int amount, int years)
        {
            return (amount - (0.5m * amount)) - disc(amount, years) * (amount - (0.5m * amount));
        }
    }









}
