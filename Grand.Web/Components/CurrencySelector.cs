﻿using Grand.Framework.Components;
using Grand.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Grand.Web.ViewComponents
{
    public class CurrencySelectorViewComponent : BaseViewComponent
    {
        private readonly ICommonViewModelService _commonViewModelService;

        public CurrencySelectorViewComponent(ICommonViewModelService commonViewModelService)
        {
            this._commonViewModelService = commonViewModelService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await Task.Run(() => _commonViewModelService.PrepareCurrencySelector());
            if (model.AvailableCurrencies.Count == 1)
                Content("");

            return View(model);
        }
    }
}