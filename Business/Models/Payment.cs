using StrategyPatternFirstLock.Business.Enums;

namespace StrategyPatternFirstLock.Business.Models;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
}