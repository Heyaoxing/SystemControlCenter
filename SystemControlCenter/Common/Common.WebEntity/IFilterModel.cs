using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.WebEntity
{
    /// <summary>
    /// 搜索参数实体接口
    /// </summary>
    public abstract  class IFilterModel
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex { set; get; } = 1;
    }
}
