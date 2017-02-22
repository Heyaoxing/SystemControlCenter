using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Business.Services;
using Common.Web.Authentication;
using Data.Repositories;
using IBusiness.Services;

namespace AdminCenter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var builder = new ContainerBuilder();
            SetupResolveRules(builder);
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void SetupResolveRules(ContainerBuilder builder)
        {
            #region 数据仓库
            builder.RegisterType<DepartmentinfoRepository>().As<IDepartmentinfoRepository>();
            builder.RegisterType<PersoninfoRepository>().As<IPersoninfoRepository>();
            #endregion

            #region 服务
            builder.RegisterType<DepartmentService>().As<IDepartmentService>();
            builder.RegisterType<PersoninfoService>().As<IPersoninfoService>();
            builder.RegisterType<FormsAuthenticationService>().As<IAuthenticationService>();
            #endregion
        }
    }
}
