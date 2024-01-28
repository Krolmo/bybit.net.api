namespace bybit.net.api;

public enum CreateType
{
    Unknown,
    CreateByUser,
    CreateByAdminClosing,
    CreateByStopOrder,
    CreateByTakeProfit,
    CreateByPartialTakeProfit,
    CreateByStopLoss,
    CreateByPartialStopLoss,
    CreateByTrailingStop,
    CreateByLiq,
    // ReSharper disable once InconsistentNaming
    CreateByTakeOver_PassThroughIf,
    // ReSharper disable once InconsistentNaming
    CreateByAdl_PassThrough,
    // ReSharper disable once InconsistentNaming
    CreateByBlock_PassThrough,
    // ReSharper disable once InconsistentNaming
    CreateByBlockTradeMovePosition_PassThrough,
    CreateByClosing,
    CreateByFGridBot,
    CloseByFGridBot,
    // ReSharper disable once InconsistentNaming
    CreateByTWAP,
    // ReSharper disable once InconsistentNaming
    CreateByTVSignal,
    CreateByMmRateClose,
    CreateByMartingaleBot,
    CloseByMartingaleBot,
    CreateByIceBerg,
    CreateByArbitrage
}