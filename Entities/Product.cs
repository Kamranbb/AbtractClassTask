

namespace AbtractClassTask.Entities
{
    internal class Product
    {
        public  string Name { get; set; }
        public  double   Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}, Count:{Count} ";
        }

        public void Discount(int discount)
        {
            Console.WriteLine(Price - (Price * discount) / 100);

        }
        }
    }
