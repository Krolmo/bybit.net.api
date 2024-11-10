using Newtonsoft.Json;

namespace bybit.net.api.Models.Position.Response;

public class PositionInfo : ICloneable
{
    [JsonProperty("positionIdx")]
    public PositionIdxType? PositionIdx { get; set; }

    [JsonProperty("riskId")]
    public int? RiskId { get; set; }

    [JsonProperty("riskLimitValue")]
    public decimal RiskLimitValue { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; } = null!;

    [JsonProperty("side")]
    public SideType Side { get; set; }

    [JsonProperty("size")]
    public decimal Size { get; set; }

    [JsonProperty("avgPrice")]
    public decimal AvgPrice { get; set; }

    [JsonProperty("positionValue")]
    public decimal PositionValue { get; set; }

    [JsonProperty("tradeMode")]
    public TradeModeType TradeMode { get; set; }

    [JsonProperty("positionStatus")]
    public PositionStatusType PositionStatus { get; set; }

    [JsonProperty("autoAddMargin")]
    public BitType AutoAddMargin { get; set; }

    [JsonProperty("adlRankIndicator")]
    public int AdlRankIndicator { get; set; }

    [JsonProperty("leverage")]
    public decimal? Leverage { get; set; }

    [JsonProperty("positionBalance")]
    public decimal? PositionBalance { get; set; }

    [JsonProperty("markPrice")]
    public decimal MarkPrice { get; set; }

    [JsonProperty("liqPrice")]
    public decimal? LiqPrice { get; set; }

    [JsonProperty("bustPrice")]
    public decimal? BustPrice { get; set; }

    [JsonProperty("positionMM")]
    public decimal? PositionMm { get; set; }

    [JsonProperty("positionIM")]
    public decimal? PositionIm { get; set; }

    [JsonProperty("takeProfit")]
    public decimal? TakeProfit { get; set; }

    [JsonProperty("stopLoss")]
    public decimal? StopLoss { get; set; }

    [JsonProperty("trailingStop")]
    public decimal? TrailingStop { get; set; }

    [JsonProperty("unrealisedPnl")]
    public decimal? UnrealisedPnl { get; set; }

    [JsonProperty("cumRealisedPnl")]
    public decimal? CumRealisedPnl { get; set; }

    [JsonProperty("seq")]
    public long Seq { get; set; }

    [JsonProperty("isReduceOnly")]
    public bool IsReduceOnly { get; set; }

    [JsonProperty("mmrSysUpdateTime")]
    public long? MmrSysUpdateTime { get; set; }

    [JsonProperty("leverageSysUpdatedTime")]
    public long? LeverageSysUpdatedTime { get; set; }

    [JsonProperty("createdTime")]
    public long CreatedTime { get; set; }

    [JsonProperty("updatedTime")]
    public long UpdatedTime { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}