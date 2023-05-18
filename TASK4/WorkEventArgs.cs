using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEvents
{
    public class WorkEventArgs : EventArgs
    {
        public string Action { get; set; }
    }
}
