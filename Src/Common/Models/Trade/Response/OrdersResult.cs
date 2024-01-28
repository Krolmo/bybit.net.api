using bybit.net.api.Models.Market.Response;
using Newtonsoft.Json;

namespace bybit.net.api.Models.Trade.Response;

public class OrdersResult : CursoredResult
{
    [JsonProperty("category")]
    public ProductType Category { get; set; }

    [JsonProperty("list")]
    public List<OrderInfo>? List { get; set; }
}