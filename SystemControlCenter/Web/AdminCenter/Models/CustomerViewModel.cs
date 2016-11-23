using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.WebEntity;

namespace AdminCenter.Models
{
    public class CustomerViewModel: IViewModel
    {
        public IPagedList<Customer> PagedList { set; get; }

        public Customer CustomerParam { set; get; }
    }
}