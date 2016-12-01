using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.Logging;
using Data.Entities;
using Data.Repositories;

namespace Test.Console.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(100);
                    Log.Error("测试");
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }
    }
}
