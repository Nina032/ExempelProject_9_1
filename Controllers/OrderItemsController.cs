﻿using AutoMapper;
using ExempelProject.Data;
using ExempelProject.Data.Entities;
using ExempelProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExempelProject.Controllers
{
    [Route("/api/orders/{orderid}/items")]
    public class OrderItemsController : Controller
    {
        private readonly IExempelRepository repository;
        private readonly ILogger logger;
        private readonly IMapper mapper;

        public OrderItemsController(IExempelRepository repository, 
            ILogger<OrderItemsController> logger, IMapper mapper)
        {
            this.repository = repository;
            this.logger = logger;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get(int orderId)
        {
            var order = repository.GetOrderById(orderId);
            if (order != null) return Ok(mapper.Map<IEnumerable<OrderItem>, 
                IEnumerable<OrderItemViewModel>>(order.Items));
            return NotFound();
            
        }
        [HttpGet("{id}")]
        public  IActionResult Get(int orderId, int id)
        {
            var order = repository.GetOrderById(orderId);
            if (order != null)
            {
                var item = order.Items.Where(i => i.Id == id).FirstOrDefault();
                if (item != null)
                {
                    return Ok(mapper.Map<OrderItem, OrderItemViewModel>(item));
                }
                
            }
            return NotFound();
        }
    }
}
