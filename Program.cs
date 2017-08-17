using DeliveryFactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;

            string m1 = $"Please select action for the  text above.";
            string m2 = $"0 - send to email";
            string m3 = $"1 - print text";
            string m4 = $"2 - save in file";

            do
            {
                Console.Clear();
                Console.WriteLine(m1);
                Console.WriteLine(m2);
                Console.WriteLine(m3);
                Console.WriteLine(m4);

                int.TryParse(Console.ReadKey().KeyChar.ToString(), out input);

            } while (!Enum.IsDefined(typeof(AgentTypes), input));

            Console.WriteLine();
            Console.WriteLine(new string('-',40));

            Service service = null;

            switch (input) {
                case (int)AgentTypes.Email:
                    service = new EmailService();
                    break;
                case (int)AgentTypes.File:
                    service = new FileService();
                    break;
                case (int)AgentTypes.Print:
                    service = new PrintService();
                    break;
                default:
                    throw new Exception("Wrond selection");
            }

            Client client = new Client(service);
            client.Run();
            Console.ReadKey();
        }
    }
}
