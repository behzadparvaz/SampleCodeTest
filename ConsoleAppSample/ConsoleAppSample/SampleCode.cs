using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    public class SampleCode
    {
        public Task Print(string message)
        {
           return Task.Run(() => {
                Task.Delay(5000);
                Console.WriteLine(message);
            });
        }
    }
}
