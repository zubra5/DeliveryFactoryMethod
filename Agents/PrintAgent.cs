using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactoryMethod.Agents
{
    class PrintAgent : Agent
    {
        public override void Process()
        {
           
        }

        public override bool Send()
        {
            Console.WriteLine(Text);
            return true;
        }

        public override void SetText(string text)
        {
            Text = text;
        }
    }
}
