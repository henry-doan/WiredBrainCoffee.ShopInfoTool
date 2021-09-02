using WiredBrainCoffee.DataAccess.Model;
using System.Collections.Generic;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockKg = 107 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockKg = 107 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockKg = 107 };
        }
    }
}
