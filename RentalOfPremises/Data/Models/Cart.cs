using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalOfPremises.Data.Models
{
    public class Cart
    {
        private readonly AppContext appContext;
        public Cart(AppContext appContext)
        {
            this.appContext = appContext;
        }
        public string CartId { get; set; }
        public List<CartItem> ListCartItem { get; set; }
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new Cart(context) { CartId = cartId };
        }
        
        public void AddToCart(Premises premises)
        {
            appContext.CartItem.Add(new CartItem
            { 
                CartId = CartId,
                Premises = premises,
                Price = premises.Price
            });

            appContext.SaveChanges();
        }
       
        public List<CartItem> getCartItems()
        {
            return appContext.CartItem.Where(c => c.CartId == CartId).Include(s => s.Premises).ToList();
        }
    }
}
