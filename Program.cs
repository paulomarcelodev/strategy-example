
using StrategyPatternFirstLock.Business.Enums;
using StrategyPatternFirstLock.Business.Models;
using StrategyPatternFirstLock.Business.Strategies.SalesTax;

var order = new Order
{
    ShippingDetails = new ShippingDetails 
    { 
        OriginCountry = "Sweden",
        DestinationCountry = "Sweden",
        DestinationState = "la"
    },
    SalesTaxStrategy = new USAStateSalesTaxStrategy()
};
            
order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

Console.WriteLine(order.GetTax());
