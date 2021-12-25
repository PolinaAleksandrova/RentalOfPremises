using RentalOfPremises.Data.Models;
using RentalOfPremises.Data.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Repository
{
    public class OrderRepository : IOrderService
    {
        private readonly AppContext appContext;
        private readonly Cart cart;

        public OrderRepository(AppContext appContext, Cart cart)
        {
            this.appContext = appContext;
            this.cart = cart;
        }
        public void CreateOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appContext.Order.Add(order);

            var items = cart.ListCartItem;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    PremisesId = el.Premises.Id,
                    OrderId = order.Id,
                    Price = el.Premises.Price
                };
                appContext.OrderDetail.Add(orderDetail);
            }
            appContext.SaveChanges();
        }
    }
}
