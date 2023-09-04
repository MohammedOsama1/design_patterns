using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.Strategy
{
    internal interface IType
    {
        double CalculateDiscount(double totalPrice);
    }
}
