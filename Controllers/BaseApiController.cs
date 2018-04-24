﻿using System;
using System.Collections.Generic;
using System.Linq;
using Athena.Data;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Athena.Controllers {
    [Route ("api/[controller]")]
    public class BaseApiController : Controller {
        #region Constructor
        public BaseApiController (ApplicationDbContext context) {
            // Instantiate the ApplicationDbContext through DI
            DbContext = context;

            // Instantiate a single JsonSerializerSettings object
            // that can be reused multiple times.
            JsonSettings = new JsonSerializerSettings () {
                Formatting = Formatting.Indented
            };

        }
        #endregion

        #region Shared Properties
        protected ApplicationDbContext DbContext { get; private set; }
        protected JsonSerializerSettings JsonSettings { get; private set; }
        #endregion
    }
}