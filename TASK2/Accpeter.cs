using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publications_subscriptions
{
    internal class Accpeter
    {
        public int Acceptprior { get; set; }

        public Accpeter (int priority)
        {
            Acceptprior = priority;
        }

        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Принятий за пріорітетом {Acceptprior} ");
        }
    }



}

