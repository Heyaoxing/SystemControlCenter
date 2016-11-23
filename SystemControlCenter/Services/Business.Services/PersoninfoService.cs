using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.WebEntity;
using Data.Entities;
using Data.Repositories;
using IBusiness.Services;

namespace Business.Services
{
    public class PersoninfoService: IPersoninfoService
    {
        private IPersoninfoRepository _personinfoRepository;

        public PersoninfoService(IPersoninfoRepository personinfoRepository)
        {
            _personinfoRepository = personinfoRepository;
        }
        //public IPagedList<Personinfo> GetList()
        //{
        //}
    }
}
