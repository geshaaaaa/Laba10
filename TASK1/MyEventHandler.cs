using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLaba
{
    internal class MyEventHandler
    {
        public void HandleEvent(object sender, MyEvent myEvent)
        {
            Console.WriteLine($"Handled event: {myEvent.Message}");
        }
    }
}
