namespace bybit.net.api.Models.Trade.Response;

public enum OrderStatus
{
    Created,
    New,
    Rejected,
    PartiallyFilled,
    PartiallyFilledCancelled,
    Filled,
    Cancelled,
    Untriggered,
    Triggered,
    Deactivated,
    Active,
}