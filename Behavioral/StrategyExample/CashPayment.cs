using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StrategyExample
{
    public class CashPayment : IPaymentStrategy //strategy realization
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment {amount} grn by cash.");
        }
    }
}
