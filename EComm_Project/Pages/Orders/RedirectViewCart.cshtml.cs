﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EComm_Project.Models;
using EComm_Project_Database.Data;

namespace EComm_Project.Pages.Orders
{
    public class RedirectViewCartModel : PageModel
    {
        private readonly EComm_Project_Database.Data.EComm_ProjectContext _context;

        public RedirectViewCartModel(EComm_Project_Database.Data.EComm_ProjectContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task<RedirectToPageResult> OnGetAsync()
        {
            Order = await _context.Order
                .Include(o => o.Customer).ToListAsync();


            var CurrentOrder = new Order();
            //var currentorderexists = true;
            var existingOrderId = 0;

            CurrentOrder = Order.FirstOrDefault(o => o.OrderStatus == false);

            if (CurrentOrder == null)
            {
                /*var newOrder = new Order();
                newOrder.Date = DateTime.Now;
                newOrder.CustomerId = 1;
                _context.Order.Add(newOrder);
                _context.SaveChanges();*/
                existingOrderId = 0;
            }
            else
            {
                // add to existing order
                existingOrderId = CurrentOrder.OrderId;

            }
            var url = "/Orders/editcart?id="+existingOrderId ;
            return RedirectToPage(url);

        }
    }
}
