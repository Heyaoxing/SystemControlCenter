using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
using IBusiness.Services;
using MySqlSugar;

namespace Business.Services
{
    public class DepartmentService : IDepartmentService
    {
        public IDepartmentinfoRepository _departmentinfoRepository;

        public DepartmentService(IDepartmentinfoRepository departmentinfoRepository)
        {
            _departmentinfoRepository = departmentinfoRepository;
        }

        /// <summary>
        /// 获取第一个部门信息
        /// </summary>
        /// <returns></returns>
        public Departmentinfo GetFirst()
        {
            return _departmentinfoRepository.Queryable().FirstOrDefault();
        }
    }
}
