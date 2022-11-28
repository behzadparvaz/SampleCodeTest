using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    public class SampleCode
    {
        public async Task PrintAsync(string message)
        {
            await Task.Run(async () => {
                await Task.Delay(5000);
                Console.WriteLine(message);
            });
        }
    }
}
