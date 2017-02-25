using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string command = Console.ReadLine();

            while (!command.Equals("END"))
            {
                string[] parsed = command.Split(' ').ToArray();

                if (parsed[0] == "A")
                {
                    try
                    {
                        phonebook.Add(parsed[1], parsed[2]);
                    }
                    catch
                    {
                        phonebook[parsed[1]] = parsed[2];
                    }

                }
                else if (parsed[0] == "S")
                {
                    string a;
                    bool Y = phonebook.TryGetValue(parsed[1], out a);
                    if (Y)
                    {
                        Console.WriteLine($"{parsed[1]} -> {a}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {parsed[1]} does not exist.");
                    }
                }
                else if (parsed[0] == "ListAll")
                {
                    foreach (var entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }

                command = Console.ReadLine();

            }
        }
    }
}
