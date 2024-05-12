using Dentistry_Diplom.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dentistry_Diplom.Data.Models
{
    public class ShopDent
    {
        DensContext db;
        public ShopDent(DensContext context)
        {
            db = context;
        }
        public string ShopDentId { get; set; }
        public List<ShopDentItem> shopDentItems { get; set; }

        //метод будет определять добавлялись ли данные в запись. 
        //Если нет, то будет создан новый Id записи.
        public static ShopDent GetDent(IServiceProvider services)
        {
            //начнем сессию...
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<DensContext>();

            //будет автоматически генерировать Id записи
            string shopDentId = session.GetString("DentId") ?? Guid.NewGuid().ToString();

            //выполняем привязку сгенерированного ключа к каждой услуге записи
            session.SetString("DentId", shopDentId);

            //вернем текущую корзину с существующими услугами
            return new ShopDent(context) { ShopDentId = shopDentId };
        }

        public void AddToDent(DentistryInfo dentistry)
        {
            db.ShopDentItem.Add(new ShopDentItem
            {
                shopDentId = ShopDentId,
                dentistry = dentistry,
                price = dentistry.price
            });
            db.SaveChanges();
        }

        public List<ShopDentItem> GetShopItems() => db.ShopDentItem
            .Where(c => c.shopDentId == ShopDentId)
            .Include(c => c.dentistry)
            .ToList();
    }
}
