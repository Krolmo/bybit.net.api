using Newtonsoft.Json;

namespace bybit.net.api.Models.Trade.Response;

public class OrderInfo
{
    [JsonProperty("orderId")]
    public string OrderId { get; set; } = null!;

    [JsonProperty("orderLinkId")]
    public string? OrderLinkId { get; set; }

    [JsonProperty("blockTradeId")]
    public string? BlockTradeId { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; } = null!;

    [JsonProperty("price")]
    public decimal? Price { get; set; }

    [JsonProperty("qty")]
    public decimal Quantity { get; set; }

    [JsonProperty("side")]
    public SideType Side { get; set; }

    [JsonProperty("isLeverage")]
    public BitType IsLeverage { get; set; }

    [JsonProperty("positionIdx")]
    public PositionIdxType PositionIdx { get; set; }

    [JsonProperty("orderStatus")]
    public OrderStatus OrderStatus { get; set; }
    
    [JsonProperty("createType")]
    public CreateType? CreateType { get; set; }

    [JsonProperty("cancelType")]
    public CancelType? CancelType { get; set; }

    [JsonProperty("rejectReason")]
    public RejectType? RejectReason { get; set; }

    [JsonProperty("avgPrice")]
    public decimal? AveragePrice { get; set; }

    [JsonProperty("leavesQty")]
    public decimal? LeavesQuantity { get; set; }

    [JsonProperty("leavesValue")]
    public decimal? LeavesValue { get; set; }

    [JsonProperty("cumExecQty")]
    public decimal? CumulativeExecutedOrderQuantity { get; set; }

    [JsonProperty("cumExecValue")]
    public decimal? CumulativeExecutedValue { get; set; }

    [JsonProperty("cumExecFee")]
    public decimal? CumulativeExecutedFee { get; set; }

    [JsonProperty("timeInForce")]
    public TimeInForceType TimeInForce { get; set; }

    [JsonProperty("orderType")]
    public OrderType? OrderType { get; set; }

    [JsonProperty("stopOrderType")]
    public StopOrderType? StopOrderType { get; set; }

    [JsonProperty("orderIv")]
    public decimal? OrderIv { get; set; }

    [JsonProperty("triggerPrice")]
    public decimal? TriggerPrice { get; set; }

    [JsonProperty("takeProfit")]
    public decimal? TakeProfit { get; set; }

    [JsonProperty("stopLoss")]
    public decimal? StopLoss { get; set; }

    [JsonProperty("tpTriggerBy")]
    public TriggerByType? TpTriggerBy { get; set; }

    [JsonProperty("slTriggerBy")]
    public TriggerByType? SlTriggerBy { get; set; }

    [JsonProperty("triggerDirection")]
    public TriggerDirectionType? TriggerDirection { get; set; }

    [JsonProperty("triggerBy")]
    public TriggerByType? TriggerBy { get; set; }

    [JsonProperty("lastPriceOnCreated")]
    public decimal? LastPriceOnCreated { get; set; }

    [JsonProperty("reduceOnly")]
    public bool? ReduceOnly { get; set; }

    [JsonProperty("closeOnTrigger")]
    public bool? CloseOnTrigger { get; set; }

    [JsonProperty("smpType")]
    public bybit.net.api.SmpType? SmpType { get; set; }

    [JsonProperty("smpGroup")]
    public int? SmpGroup { get; set; }

    [JsonProperty("smpOrderId")]
    public string? SmpOrderId { get; set; }

    [JsonProperty("tpslMode")]
    public TakeProfitStopLossMode? TpslMode { get; set; }

    [JsonProperty("tpLimitPrice")]
    public decimal? TakeProfitLimitPrice { get; set; }

    [JsonProperty("slLimitPrice")]
    public decimal? StopLossLimitPrice { get; set; }

    [JsonProperty("placeType")]
    public PlaceType? PlaceType { get; set; }

    [JsonProperty("createdTime")]
    public long CreatedTime { get; set; }

    [JsonProperty("updatedTime")]
    public long UpdatedTime { get; set; }
}