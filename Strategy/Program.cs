using Strategy.Models;
using Strategy.Models.Strategy;

namespace loka
{

   public class Program { 
        
        public static void Main(string[] args)
        {
            List<Customer> list = new() {
                 new Customer { Id = 1 , Name = "Mohamed Osama" , UserType =  new GoldenType()  },
                 new Customer { Id = 2 , Name = "Loka esam" , UserType = new SilverType()  },
                 new Customer { Id = 3 , Name = "saied abu" , UserType = new NormalType() },
            
            };
            while (true) { 
            Console.WriteLine("Enter User Id");
            var Id = Console.ReadLine();
            var customer = list.FirstOrDefault(x => x.Id == int.Parse(Id));

            if (customer != null)
            {
                Console.WriteLine("Cash amount");
                var cash = double.Parse(Console.ReadLine());

                double discount = customer.CalculateDiscount(cash);
                Console.WriteLine($"Discount for {customer.Name}: {discount}");
            }
            else
            {
                Console.WriteLine("User not found");
            }
            }


        }

    }

}