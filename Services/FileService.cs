using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryFactoryMethod.Agents;

namespace DeliveryFactoryMethod.Services
{
    class FileService : Service
    {
        public override Agent CreateAgent()
        {
            return new FileAgent();
        }
    }
}
