using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
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
                DepartmentinfoRepository departmentinfoRepository = new DepartmentinfoRepository();
                departmentinfoRepository.Insert(new Departmentinfo()
                {
                    Name = "测试",
                    Address = "地址",
                    Sort = 0,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                });
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }
    }
}
