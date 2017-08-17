using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactoryMethod.Agents
{
    class EmailAgent : Agent
    {
        public override void Process()
        {
            Console.WriteLine($"{this.ToString()}: Process. ");
        }

        public override bool Send()
        {
            Console.WriteLine($"{this.ToString()}: Send. ");
            return true;
        }

        public override void SetText(string text)
        {
            Console.WriteLine($"{this.ToString()}: SetText. Text={text}");
        }
    }
}
