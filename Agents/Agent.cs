using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactoryMethod.Agents
{
    abstract class Agent
    {
        protected string Text { get; set; }
        public abstract void SetText(string text);

        public abstract void Process();

        public abstract bool Send();
    }
}
