using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> NameEmail = new Dictionary<string, string>();
            
            while (true)
            {
                string name = Console.ReadLine();
                string email;
                if (!name.Contains("stop"))
                {
                    email = Console.ReadLine().ToLower();
                    string[] domain = email.Split('.').Skip(1).ToArray();

                    if(domain[0] == "us" || domain[0] == "uk")
                    {
                        continue;
                    }
                    else
                    {
                        NameEmail.Add(name, email);
                    }

                }
                else
                {
                    break;
                }

            }

            //foreach (var entry in NameEmail)
            //{
            //    string[] domain = entry.Value.ToLower().Split('.').Skip(1).ToArray();

            //    if(domain[0].Contains("us") || domain[0].Contains("uk"))
            //    {
            //        NameEmail.Remove(entry.Key);
            //    }
            //}

            foreach (var entry in NameEmail)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
