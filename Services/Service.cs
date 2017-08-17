using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryFactoryMethod.Agents;


namespace DeliveryFactoryMethod.Services
{
    abstract class Service
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <returns></returns>
        public abstract Agent CreateAgent();
    }
}
