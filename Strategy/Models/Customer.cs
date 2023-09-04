using Strategy.Models.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    internal class Customer
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public IType UserType { get; set; }
        public double CalculateDiscount(double totalPrice)
        {
            return UserType.CalculateDiscount(totalPrice);
        }
    }
}
enum UserType { Golden, Silver , Normal };