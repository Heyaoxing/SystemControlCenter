using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminCenter.Models;
using Common.WebEntity;
using IBusiness.Services;
using Webdiyer.WebControls.Mvc;

namespace AdminCenter.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersoninfoService _ipersPersoninfoService;
        public PersonController(IPersoninfoService ipersPersoninfoService)
        {
            _ipersPersoninfoService = ipersPersoninfoService;
        }

        // GET: Person
        public ActionResult Index()
        {
            //CustomerViewModel filterModel =new CustomerViewModel();
            //filterModel.CustomerParam=new Customer();
            //filterModel.CustomerParam.Name = "测试";
            //List<Customer> data = Bind();
            //filterModel.PagedList = data.AsQueryable().ToPagedList(filter.PageIndex, filter.PageIndex);
            //filterModel.PagedList.TotalItemCount = data.Count;
            //filterModel.PagedList.CurrentPageIndex = filter.PageIndex;
            PersonViewModel personView=new PersonViewModel();
            personView.PagedList=_ipersPersoninfoService.GetList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_List", personView);
            }

            return View(personView);
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