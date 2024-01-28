namespace bybit.net.api;

public enum CancelType
{
    CancelByUser,
    CancelByReduceOnly,
    CancelByPrepareLiq,
    CancelAllBeforeLiq,
    CancelByPrepareAdl,
    CancelAllBeforeAdl,
    CancelByAdmin,
    CancelByTpSlTsClear,
    CancelByPzSideCh,
    CancelBySmp,
    CancelBySettle,
    CancelByCannotAffordOrderCost,
    CancelByPmTrialMmOverEquity,
    CancelByAccountBlocking,
    CancelByDelivery,
    CancelByMmpTriggered,
    CancelByCrossSelfMuch,
    CancelByCrossReachMaxTradeNum,
    // ReSharper disable once InconsistentNaming
    CancelByDCP,
}