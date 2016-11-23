using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;

namespace Common.Web.PageHelper
{
    public static class ScriptResourceExtensions
    {
        public static void RegisterMvcPagerScriptResource(this HtmlHelper html)
        {
            var page = html.ViewContext.HttpContext.CurrentHandler as Page;
            var scriptUrl = (page ?? new Page()).ClientScript.GetWebResourceUrl(typeof(PagerHelper), "Webdiyer.WebControls.Mvc.MvcPager.min.js");
            html.ViewContext.Writer.Write("<script type=\"text/javascript\" src=\"" + scriptUrl + "\"></script>");
        }
    }
}
