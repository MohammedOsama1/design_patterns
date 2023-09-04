using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.Strategy
{
    internal class GoldenType : IType
    {
       public double CalculateDiscount(double totalPrice) {

        return totalPrice *0.2;

        }
    }
}
