using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.Common.Pager
{
    public class PagedList<T> : IPagedList<T>
    {
        public PagedList()
        {
            this.PageSize = 15;
            this.PageIndex = 1;
            this.EntityList = new List<T>();
        }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount { set; get; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages { set; get; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageSize { get; set; }


        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPreviousPage
        {
            get { return PageIndex > 1; }
        }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool HasNextPage
        {
            get { return (PageIndex < TotalPages && TotalPages > 1); }
        }

        /// <summary>
        /// 数据列表
        /// </summary>
        public List<T> EntityList { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return EntityList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       

        /// <summary>
        /// 创建分页的强类型对象列表
        /// </summary>
        /// <param name="source">未分页的对象列表</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页记录数</param>
        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize)
            : this(source.AsQueryable(), pageIndex, pageSize)
        {

        }

        /// <summary>
        /// 创建分页的强类型对象列表
        /// </summary>
        /// <param name="source">已分页的对象列表</param>
        /// <param name="totalRecords">总记录数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页记录数</param>
        public PagedList(IEnumerable<T> source, int totalRecords, int pageIndex, int pageSize)
            : this(source.AsQueryable(), totalRecords, pageIndex, pageSize)
        {

        }

        /// <summary>
        /// 创建分页的强类型对象列表
        /// </summary>
        /// <param name="source">已分页的对象列表</param>
        /// <param name="totalRecords">总记录数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页记录数</param>
        public PagedList(IQueryable<T> source, int totalRecords, int pageIndex, int pageSize)
        {
            this.TotalCount = totalRecords;

            this.TotalPages = totalRecords / pageSize;

            if (totalRecords % pageSize > 0)
                this.TotalPages++;

            this.PageSize = pageSize;

            this.PageIndex = pageIndex;

            this.EntityList = new List<T>();

            this.EntityList.AddRange(source.ToList());
        }

        public PagedList(IQueryable<T> source, int PageIndex, int PageSize)
        {
            PageIndex = PageIndex < 1 ? 1 : PageIndex;
            PageSize = PageSize < 1 ? 20 : PageSize;
            int total = source.Count();

            this.PageIndex = PageIndex;
            this.PageSize = PageSize;
            this.TotalCount = total;
            this.TotalPages = (total / PageSize) + ((total % PageSize) == 0 ? 0 : 1);

            this.EntityList = new List<T>();
            this.EntityList.AddRange(source.Skip((PageIndex - 1) * PageSize).Take(PageSize));

        }
    }
}
