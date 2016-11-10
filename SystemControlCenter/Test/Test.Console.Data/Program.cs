using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Data.Entities;
using Data.Repositories;
using IServices.Demo;
using MySqlSugar;

namespace Test.Console.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<Services.Demo.Test>();
                builder.RegisterType<T_exclude_websitesRepository>().As<IT_exclude_websitesRepository>();
               
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }
    }
}
