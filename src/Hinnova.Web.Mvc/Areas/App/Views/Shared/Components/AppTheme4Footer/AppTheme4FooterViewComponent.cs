﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hinnova.Web.Areas.App.Models.Layout;
using Hinnova.Web.Session;
using Hinnova.Web.Views;

namespace Hinnova.Web.Areas.App.Views.Shared.Components.AppTheme4Footer
{
    public class AppTheme4FooterViewComponent : HinnovaViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme4FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
