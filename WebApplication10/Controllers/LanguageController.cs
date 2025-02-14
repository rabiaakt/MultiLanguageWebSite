﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebApplication10.Controllers
{
    public class LanguageController : Controller
    {
     
        public ActionResult ChangeLanguage(string language)
        {
            if (language != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
            HttpCookie cookie = new HttpCookie("language")
            {
                Value = language
            };

            Response.Cookies.Add(cookie);
          //  GetCurrentCulture(cookie);
            return RedirectToAction("Index", "Home");
        }

    }
}