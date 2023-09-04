using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.Strategy
{
    internal class NormalType : IType
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice;
        }
    }
}
