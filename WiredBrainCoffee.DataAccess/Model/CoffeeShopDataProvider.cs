using WiredBrainCoffee.DataAccess.Model;
using System.Collections.Generic;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop 
            { 
                Location = "Frankfurt", 
                BeansInStockKg = 107,
                PaperCupsInStock = 350
            };
            yield return new CoffeeShop 
            { 
                Location = "Freiburg", 
                BeansInStockKg = 107, 
                PaperCupsInStock = 250
            };
            yield return new CoffeeShop 
            { 
                Location = "Munich", 
                BeansInStockKg = 107, 
                PaperCupsInStock = 427
            };
        }
    }
}
