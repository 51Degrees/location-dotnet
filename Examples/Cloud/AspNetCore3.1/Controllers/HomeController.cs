﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FiftyOne.GeoLocation.Core.Data;
using FiftyOne.Pipeline.JavaScriptBuilder.Data;
using FiftyOne.Pipeline.JsonBuilder.Data;
using FiftyOne.Pipeline.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore31.Controllers
{
    public class HomeController : Controller
    {
        private IFlowDataProvider _flow;

        public HomeController(IFlowDataProvider flow)
        {
            _flow = flow;
        }

        public IActionResult Index()
        {
            var data = _flow.GetFlowData().Get<IGeoData>();
            return View(data);
        }

        /// <summary>
        /// Endpoint that will be called by the client-side code to get 
        /// the JSON formatted results from the Pipeline.
        /// </summary>
        /// <returns>
        /// The output of the Pipeline for the current request formatted 
        /// as JSON.
        /// </returns>
        public IActionResult Json()
        {
            return new ContentResult()
            {
                Content = _flow.GetFlowData().Get<IJsonBuilderElementData>().Json,
                ContentType = "application/json"
            };
        }
    }
}
