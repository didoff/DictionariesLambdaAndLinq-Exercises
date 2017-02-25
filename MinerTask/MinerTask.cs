using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            string resourceName = Console.ReadLine();
            int resourceQuantity = int.Parse(Console.ReadLine());

            // What if inputs are stop?

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while(true)
            {
                try
                {
                    resources.Add(resourceName, resourceQuantity);
                }
                catch
                {
                    int previous;
                    bool y = resources.TryGetValue(resourceName, out previous);

                    resources[resourceName] = resourceQuantity + previous;

                }
                
                resourceName = Console.ReadLine();
                if(resourceName != "stop")
                {
                    resourceQuantity = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            

                foreach (var entry in resources)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
