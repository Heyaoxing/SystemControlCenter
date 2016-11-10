using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using IServices.Demo;
using MySqlSugar;

namespace Services.Demo
{
    public class Test
    {
         T_exclude_websitesRepository repository;

        public Test(T_exclude_websitesRepository _repository)
        {
            repository = _repository;
        }
        public void Method()
        {
            var model= repository.Queryable().Where(p => p.ID==1).FirstOrDefault();
        }
    }
}
