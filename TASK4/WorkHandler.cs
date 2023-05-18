using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEvents
{
    public class WorkHandler
    {
   public void HandleWorkflowAction(object sender, WorkEventArgs e)
        {
            Console.WriteLine($"Виконується дія: {e.Action}");
        }
    }
}
