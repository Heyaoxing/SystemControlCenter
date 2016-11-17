using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.WebEntity
{
    public interface IPagedList : IEnumerable
    {
        int CurrentPageIndex { get; set; }
        int PageSize { get; set; }
        int TotalItemCount { get; set; }
    }
    public interface IPagedList<T> : IEnumerable<T>, IPagedList { }
}
