using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactoryMethod.Agents
{
    class FileAgent : Agent
    {
        public override void Process()
        {
            Console.WriteLine("Now I am processing something");
        }

        public override bool Send()
        {
            Console.WriteLine("I saved text");
            return true;
        }

        public override void SetText(string text)
        {
            Console.WriteLine($"Hi! I am FileAgent. And I save into me Text={text}");
        }
    }
}
