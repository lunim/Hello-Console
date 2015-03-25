using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new List<String>();

            message.Add("Hello");
            message.Add("Console!");

            foreach (var entry in message)
            {
                Console.WriteLine(entry);
            }

            Console.ReadLine();
        }
    }
}
