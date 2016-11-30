using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.WebEntity;
using Data.Entities;

namespace AdminCenter.Models
{
    public class PersonViewModel
    {
        public IPagedList<Personinfo> PagedList { set; get; }
    }
}