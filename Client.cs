using DeliveryFactoryMethod.Agents;
using DeliveryFactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactoryMethod
{
    class Client
    {
        public string Text { get {
                return "How are you? Is everything ok? Would you like a cup of coffee?";
            } }
        protected Service Service { get; set; }

        public Client(Service service) {
            Service = service;
        }
        public void Run() {
            //call Factory Method
            Agent agnt=Service.CreateAgent();
            //Then using of Builder Pattern
            agnt.SetText(Text);
            agnt.Process();
            agnt.Send();
        }
    }
}
