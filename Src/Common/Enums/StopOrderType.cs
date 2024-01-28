namespace bybit.net.api;

public enum StopOrderType
{
    TakeProfit,
    StopLoss,
    TrailingStop,
    Stop,
    PartialTakeProfit,
    PartialStopLoss,
    // ReSharper disable once InconsistentNaming
    tpslOrder,
    OcoOrder,
    MmRateClose,
    // ReSharper disable once IdentifierTypo
    BidirectionalTpslOrder,
}