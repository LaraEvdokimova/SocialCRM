﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialCRM.Domain.Abstractions;

namespace SocialCRM.Web.Controllers
{
    public class OrderStatisticController : BaseController
    {
        private readonly IOrderAnalyticService _orderStatisticService;

        public OrderStatisticController(IOrderAnalyticService orderStatisticService)
        {
            _orderStatisticService = orderStatisticService;
        }

        public async Task<ActionResult<int>> GetAmountPriceByCompany(Guid companyId)
        {
            var result = await _orderStatisticService.GetAmountByCompany(companyId);

            return Ok(result);
        }
    }
}