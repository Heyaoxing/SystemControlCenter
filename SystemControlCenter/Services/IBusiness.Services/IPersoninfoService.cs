using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.WebEntity;
using Data.Entities;

namespace IBusiness.Services
{
    public interface IPersoninfoService
    {
        /// <summary>
        /// 获取角色所有列表
        /// </summary>
        /// <returns></returns>
        IPagedList<Personinfo> GetList();
    }
}
