using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Ajax;

namespace Common.Web.PageHelper
{
    public class MvcAjaxOptions : AjaxOptions
    {
        public bool EnablePartialLoading { get; set; }
        public string DataFormId { get; set; }
    }
}
