using StrategyPatternFirstLock.Business.Models;

namespace StrategyPatternFirstLock.Business.Strategies.SalesTax;

public interface ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order);
}
