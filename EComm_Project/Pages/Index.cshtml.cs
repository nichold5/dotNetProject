﻿using EComm_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Order> Order { get; set; }

        public IActionResult OnPostViewCartAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            /*var CurrentOrder = new Order();
            //var currentorderexists = true;
            var existingOrderId = 0;

            CurrentOrder = Order.FirstOrDefault(o => o.OrderStatus == false);

            if (CurrentOrder == null)
            {
                *//*var newOrder = new Order();
                newOrder.Date = DateTime.Now;
                newOrder.CustomerId = 0;*/
                /*_context.Order.Add(newOrder);
                _context.SaveChanges();*//*
                existingOrderId = 0;
            }
            else
            {
                // add to existing order
                existingOrderId = CurrentOrder.OrderId;

            }*/

            return RedirectToPage("Orders/RedirectViewCart");
        }
        public void OnGet()
        {
            

        }

        public IList<Order> Orders { get; set; }
        //public async Task<IActionResult> AddToCart()
        public IActionResult OnPostAddToCartAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            /*var viewOrder = new Order();
            Orders = await _context.Orders.ToListAsync();*/

            return RedirectToPage("Orders/Redirect" );
        }
    }
}
