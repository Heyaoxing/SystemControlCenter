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
    public abstract class IFilterModel
    {
       
        public int PageIndex
        {
            set { this._pageIndex = value; }
            get { return this._pageIndex; }
        }
        /// <summary>
        /// 当前页数
        /// </summary>
        private int _pageIndex = 1;
        /// <summary>
        /// 当前显示页数.默认20
        /// </summary>
        private int _pageSize = 20;
        public int PageSize
        {
            set { this._pageSize = value; }
            get { return this._pageSize; }
        }
      
    }
}
