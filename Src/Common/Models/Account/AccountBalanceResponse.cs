using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace bybit.net.api.ApiServiceImp;


public class AccountBalanceResponse
{
    public List<AccountBalanceResult> List { get; set; } = new();
}

public class AccountBalanceResult
{
    [JsonProperty("totalEquity")]
    public decimal TotalEquity { get; set; }

    [JsonProperty("accountIMRate")]
    public decimal AccountImRate { get; set; }

    [JsonProperty("totalMarginBalance")]
    public decimal TotalMarginBalance { get; set; }

    [JsonProperty("totalInitialMargin")]
    public decimal TotalInitialMargin { get; set; }

    [JsonProperty("accountType")]
    public string AccountType { get; set; } = null!;

    [JsonProperty("totalAvailableBalance")]
    public decimal TotalAvailableBalance { get; set; }

    [JsonProperty("accountMMRate")]
    public decimal AccountMmRate { get; set; }

    [JsonProperty("totalPerpUPL")]
    public decimal TotalPerpUpl { get; set; }

    [JsonProperty("totalWalletBalance")]
    public decimal TotalWalletBalance { get; set; }

    [JsonProperty("accountLTV")]
    public decimal AccountLtv { get; set; }

    [JsonProperty("totalMaintenanceMargin")]
    public decimal TotalMaintenanceMargin { get; set; }

    [JsonProperty("coin")]
    public List<CoinResult> Coin { get; set; } = new();
}

public class CoinResult
{
    [JsonProperty("availableToBorrow")]
    public decimal? AvailableToBorrow { get; set; }

    [JsonProperty("bonus")]
    public decimal? Bonus { get; set; }

    [JsonProperty("accruedInterest")]
    public decimal? AccruedInterest { get; set; }

    [JsonProperty("availableToWithdraw")]
    public decimal? AvailableToWithdraw { get; set; }

    [JsonProperty("totalOrderIM")]
    public decimal? TotalOrderIm { get; set; }

    [JsonProperty("equity")]
    public decimal? Equity { get; set; }

    [JsonProperty("totalPositionMM")]
    public decimal? TotalPositionMm { get; set; }

    [JsonProperty("usdValue")]
    public decimal UsdValue { get; set; }

    [JsonProperty("spotHedgingQty")]
    public decimal? SpotHedgingQty { get; set; }

    [JsonProperty("unrealisedPnl")]
    public decimal UnrealisedPnl { get; set; }

    [JsonProperty("collateralSwitch")]
    public bool CollateralSwitch { get; set; }

    [JsonProperty("borrowAmount")]
    public decimal? BorrowAmount { get; set; }

    [JsonProperty("totalPositionIM")]
    public decimal? TotalPositionIm { get; set; }

    [JsonProperty("walletBalance")]
    public decimal WalletBalance { get; set; }

    [JsonProperty("cumRealisedPnl")]
    public decimal CumRealisedPnl { get; set; }

    [JsonProperty("locked")]
    public decimal Locked { get; set; }

    [JsonProperty("marginCollateral")]
    public bool MarginCollateral { get; set; }

    [JsonProperty("coin")]
    public string Coin { get; set; } = null!;
}