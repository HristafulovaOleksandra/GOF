﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Behavioral.StrategyExample
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
