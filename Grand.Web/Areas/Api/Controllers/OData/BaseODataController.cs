﻿using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace Grand.Web.Areas.Api.Controllers.OData
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public abstract partial class BaseODataController : ODataController
    {
    }
}
