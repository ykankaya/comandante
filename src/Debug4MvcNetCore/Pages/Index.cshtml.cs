﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Debug4MvcNetCore.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Debug4MvcNetCore.Pages
{
    public class Index : EmbeddedPageModel
    {
        public IndexModel Model { get; set; }

        public override async Task InitPage()
        {
            Model = new IndexModel();
            Model.DebugInfo = new DebugInfoService().Create(this.HttpContext);
        }
    }

    public class IndexModel
    {
        public DebugInfo DebugInfo = new DebugInfo();
    }

}
