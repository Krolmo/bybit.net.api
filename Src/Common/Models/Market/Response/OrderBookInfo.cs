using Newtonsoft.Json;

namespace bybit.net.api.Models.Market.Response;

public class OrderBookInfo
{
    [JsonProperty("s")]
    public string Symbol { get; set; } = null!;

    [JsonProperty("a")]
    public List<decimal[]> Asks { get; set; } = null!;

    [JsonProperty("b")]
    public List<decimal[]> Bids { get; set; } = null!;

    [JsonProperty("ts")]
    public long Ts { get; set; }

    [JsonProperty("u")]
    public long U { get; set; }
}