using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.Logging;
using Common.RabbitMQ;
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
                RabbitMQueue reRabbitMQueue=new RabbitMQueue();
                System.Console.WriteLine(reRabbitMQueue.Count("hyx"));
               
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }

        /// <summary>
        /// 获取主域
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetMasterHost(string url)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url))
                    return string.Empty;
                if (url.Contains(".com.cn"))
                {
                    url = url.Replace(".cn", "");
                }
                int index = url.LastIndexOf(".", StringComparison.Ordinal);
                string _url = url.Remove(index);
                return url.Remove(0, _url.LastIndexOf(".", StringComparison.Ordinal));
            }
            catch
            {
                // ignored
            }
            return string.Empty;
        }
    }
}
