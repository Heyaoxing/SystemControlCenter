using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace IBusiness.Services
{
    public interface IDepartmentService
    {
        /// <summary>
        /// 获取第一个部门信息
        /// </summary>
        /// <returns></returns>
        Departmentinfo GetFirst();
    }
}
