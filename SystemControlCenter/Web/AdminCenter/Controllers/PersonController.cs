using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminCenter.Models;
using Common.Web.PageHelper;
using Common.WebEntity;

namespace AdminCenter.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index(int pageindex=1)
        {
            List<Customer> data = Bind();
            PagedList<Customer> InfoPager = data.AsQueryable().ToPagedList(pageindex, 2);
            InfoPager.TotalItemCount = data.Count;
            InfoPager.CurrentPageIndex = pageindex;

            return View(InfoPager);
        }

        private List<Customer> Bind()
        {
            List<Customer> data = new List<Customer>();
            data.Add(new Customer()
            {
                Id = 1,
                Name = "我是谁",
                Descript = "不可描述"
            });
            data.Add(new Customer()
            {
                Id = 2,
                Name = "我是谁",
                Descript = "不可描述"
            });
            data.Add(new Customer()
            {
                Id = 3,
                Name = "我是谁",
                Descript = "不可描述"
            });
            for (int i = 0; i < 20; i++)
            {
                data.Add(new Customer()
                {
                    Id = i + 3,
                    Name = "我是谁",
                    Descript = "不可描述"
                });
            }

            return data;
        }
    }
}