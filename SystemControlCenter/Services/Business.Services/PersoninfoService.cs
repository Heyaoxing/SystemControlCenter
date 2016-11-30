using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.WebEntity;
using Data.Entities;
using Data.Repositories;
using IBusiness.Services;
using MySqlSugar;

namespace Business.Services
{
    public class PersoninfoService : IPersoninfoService
    {
        private IPersoninfoRepository _personinfoRepository;

        public PersoninfoService(IPersoninfoRepository personinfoRepository)
        {
            _personinfoRepository = personinfoRepository;
        }
        /// <summary>
        /// 获取角色所有列表
        /// </summary>
        /// <returns></returns>
        public IPagedList<Personinfo> GetList()
        {
            PagedList<Personinfo> pagedList = _personinfoRepository.Queryable().OrderBy("PersonId").ToPagedList(1,10);
            return pagedList;
        }
    }
}
