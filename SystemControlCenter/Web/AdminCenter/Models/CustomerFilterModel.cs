using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.WebEntity;

namespace AdminCenter.Models
{
    public class CustomerFilterModel: IFilterModel
    {
        public CustomerFilterModel()
        {
            CustomerParam=new Customer();
        }
        public Customer CustomerParam { set; get; }
    }
}