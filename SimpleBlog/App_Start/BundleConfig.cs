﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/Admin.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/Site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/Scripts/jquery-2.1.1.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/Scripts/jquery-2.1.1.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js"));
        }        
    }
}