using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryFactoryMethod.Agents;

namespace DeliveryFactoryMethod.Services
{
    class EmailService : Service
    {
        public override Agent CreateAgent()
        {
            return new EmailAgent();
        }
    }
}
