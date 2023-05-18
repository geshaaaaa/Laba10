using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandDelayevent
{ 
        public class AcceptPrior
        {
            public int Accept { get; set; }

            public AcceptPrior(int accept)
            {
                Accept = accept;
            }
            public void HandleEvent(object sender, EventArgs args)
            {
                Console.WriteLine($"Принятий за пріорітетом {Accept} ");
            }
        }
}
