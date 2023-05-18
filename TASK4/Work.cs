using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEvents
{
    public class Work
    {

        public event EventHandler<WorkEventArgs> WorkflowAction;
        public void Run()
        {

            WorkAction("Старт");


            WorkAction("Дія1");


            WorkAction("Дія2");


            WorkAction("Кінець");
        }
        protected virtual void WorkAction(string action)
        {
       
            if (WorkflowAction != null)
            {
               
                WorkEventArgs args = new WorkEventArgs() { Action = action };

                
                WorkflowAction.Invoke(this, args);
            }
        }
    
}
}
