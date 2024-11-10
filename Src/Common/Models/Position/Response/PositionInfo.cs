using bybit.net.api.Models.Trade;
using Newtonsoft.Json;

namespace bybit.net.api.Models.Position.Response;

public class PositionInfo : ICloneable
{
    [JsonProperty("positionIdx")]
    public PositionIdxType? PositionIdx { get; init; }

    [JsonProperty("riskId")]
    public int? RiskId { get; init; }

    [JsonProperty("riskLimitValue")]
    public decimal RiskLimitValue { get; init; }

    [JsonProperty("symbol")]
    public string Symbol { get; init; } = null!;

    [JsonProperty("side")]
    public SideType Side { get; init; }

    [JsonProperty("size")]
    public decimal Size { get; init; }
    
    [JsonProperty("entryPrice")]
    public decimal EntryPrice { get; init; }

    [JsonProperty("avgPrice")]
    private decimal AvgPrice {
        init => EntryPrice = value;
    }

    [JsonProperty("positionValue")]
    public decimal PositionValue { get; init; }

    [JsonProperty("tradeMode")]
    public TradeModeType TradeMode { get; init; }

    [JsonProperty("positionStatus")]
    public PositionStatusType PositionStatus { get; init; }

    [JsonProperty("autoAddMargin")]
    public BitType AutoAddMargin { get; init; }

    [JsonProperty("adlRankIndicator")]
    public int AdlRankIndicator { get; init; }

    [JsonProperty("leverage")]
    public decimal? Leverage { get; init; }

    [JsonProperty("positionBalance")]
    public decimal? PositionBalance { get; init; }

    [JsonProperty("markPrice")]
    public decimal MarkPrice { get; init; }

    [JsonProperty("liqPrice")]
    public decimal? LiqPrice { get; init; }

    [JsonProperty("bustPrice")]
    public decimal? BustPrice { get; init; }

    [JsonProperty("positionMM")]
    public decimal? PositionMm { get; init; }

    [JsonProperty("positionIM")]
    public decimal? PositionIm { get; init; }

    [JsonProperty("takeProfit")]
    public decimal? TakeProfit { get; init; }

    [JsonProperty("stopLoss")]
    public decimal? StopLoss { get; init; }

    [JsonProperty("trailingStop")]
    public decimal? TrailingStop { get; init; }

    [JsonProperty("unrealisedPnl")]
    public decimal? UnrealisedPnl { get; init; }
    
    [JsonProperty("curRealisedPnl")]
    public decimal? CurrentRealisedPnl { get; init; }

    [JsonProperty("cumRealisedPnl")]
    public decimal? CumRealisedPnl { get; init; }

    [JsonProperty("seq")]
    public long Seq { get; init; }

    [JsonProperty("isReduceOnly")]
    public bool IsReduceOnly { get; init; }

    [JsonProperty("mmrSysUpdateTime")]
    public long? MmrSysUpdateTime { get; init; }

    [JsonProperty("leverageSysUpdatedTime")]
    public long? LeverageSysUpdatedTime { get; init; }
    
    [JsonProperty("mmrSysUpdatedTime")]
    public long? MmrSysUpdatedTime { get; init; }

    [JsonProperty("createdTime")]
    public long CreatedTime { get; init; }

    [JsonProperty("updatedTime")]
    public long UpdatedTime { get; init; }
    
    [JsonProperty("tpslMode")]
    public TpslMode? TpslMode { get; init; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}