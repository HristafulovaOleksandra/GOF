using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StrategyExample
{
    public class Order //use strategy
    {
        private IPaymentStrategy paymentStrategy;

        public Order(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}
