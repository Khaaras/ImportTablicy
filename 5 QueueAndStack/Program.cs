using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> queue = new Queue<Customer>();

            queue.Enqueue(new Customer { Name = "Łukasz" });
            queue.Enqueue(new Customer { Name = "Andrzej" });
            queue.Enqueue(new Customer { Name = "Basia" });
            queue.Enqueue(new Customer { Name = "Marcin" });
            queue.Enqueue(new Customer { Name = "Ola" });
            queue.Enqueue(new Customer { Name = "Piotrek" });

            while(queue.Count > 0)
            {
                Console.WriteLine("Ilość w kolejce przed funkcją: " + queue.Count);
                var customer = queue.Dequeue();
                Console.WriteLine(customer.Name);
                Console.WriteLine("Ilość w kolejce po funkcji: " + queue.Count);
                Console.WriteLine("----");
            }

            Console.ReadKey();
        }
    }
}
