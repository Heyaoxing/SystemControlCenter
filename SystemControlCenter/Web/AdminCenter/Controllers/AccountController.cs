﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using AdminCenter.Models;
using Common.Web;
using Common.Web.Authentication;


namespace AdminCenter.Controllers
{
    public class AccountController : Controller
    {
        IAuthenticationService _formsAuthenticationService;
        public AccountController(IAuthenticationService formsAuthenticationService)
        {
            _formsAuthenticationService = formsAuthenticationService;
        }

        [HttpGet]
        public ActionResult Login(string BackReturnUrl)
        {
            ViewBag.BackReturnUrl = BackReturnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var BackReturnUrl = model.BackReturnUrl.Decrypt();

            if (ModelState.IsValid)
            {
                bool result = model.UserName == "hyx" && model.Password == "123";
                if (result)
                {
                    _formsAuthenticationService.SignIn(new UserData() {UserName = model.UserName}, false);
                    return Redirect(BackReturnUrl);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}