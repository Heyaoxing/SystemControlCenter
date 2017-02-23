using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.RabbitMQ;

namespace Test.Console.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RabbitMQueue reRabbitMQueue = new RabbitMQueue();
                reRabbitMQueue.ListenInit("hyx");
                reRabbitMQueue.ReceiveMessageCallback = message =>
                {
                    System.Console.WriteLine(message);
                    Thread.Sleep(3000);
                    return true;
                };
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }
    }
}
