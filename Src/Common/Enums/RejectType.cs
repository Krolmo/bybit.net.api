// ReSharper disable InconsistentNaming
namespace bybit.net.api;

public enum RejectType
{
    EC_NoError,
    EC_Others,
    EC_UnknownMessageType,
    EC_MissingClOrdID,
    EC_MissingOrigClOrdID,
    EC_ClOrdIDOrigClOrdIDAreTheSame,
    EC_DuplicatedClOrdID,
    EC_OrigClOrdIDDoesNotExist,
    EC_TooLateToCancel,
    EC_UnknownOrderType,
    EC_UnknownSide,
    EC_UnknownTimeInForce,
    EC_WronglyRouted,
    EC_MarketOrderPriceIsNotZero,
    EC_LimitOrderInvalidPrice,
    EC_NoEnoughQtyToFill,
    EC_NoImmediateQtyToFill,
    EC_PerCancelRequest,
    EC_MarketOrderCannotBePostOnly,
    EC_PostOnlyWillTakeLiquidity,
    EC_CancelReplaceOrder,
    EC_InvalidSymbolStatus,
    EC_CancelForNoFullFill
}