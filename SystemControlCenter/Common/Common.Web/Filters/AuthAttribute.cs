using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Common.Web.Filters
{
    public class AuthAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 验证权限（action执行前会先执行这里）
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string url = HttpContext.Current.Request.Url.AbsolutePath;
            string strHost = HttpContext.Current.Request.Url.Host;
            string strPort = HttpContext.Current.Request.Url.Port.ToString();
            string backUrl = String.Format("http://{0}:{1}{2}", strHost, strPort, HttpContext.Current.Request.RawUrl);

            //如果存在身份信息
            if (!HttpContext.Current.User.Identity.IsAuthenticated && url != FormsAuthentication.LoginUrl)
            {
                ContentResult Content = new ContentResult();
                Content.Content = string.Format("<script type='text/javascript'>alert('请先登录！');window.location.href='{0}?';</script>", FormsAuthentication.LoginUrl);
                filterContext.Result = Content;
            }
        }
    }
}
