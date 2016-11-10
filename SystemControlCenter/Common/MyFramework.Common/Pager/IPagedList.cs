using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.Common.Pager
{
    public interface IPagedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        int PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// 是否有上一页
        /// </summary>
        bool HasPreviousPage { get; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        bool HasNextPage { get; }

        /// <summary>
        /// 数据列表
        /// </summary>
        List<T> EntityList { get; set; }
    }
}
