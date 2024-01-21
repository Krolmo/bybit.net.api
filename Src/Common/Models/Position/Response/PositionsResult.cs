using bybit.net.api.Models.Market.Response;
using Newtonsoft.Json;

namespace bybit.net.api.Models.Position.Response;

public class PositionsResult: CursoredResult
{
    [JsonProperty("category")]
    public ProductType Category { get; set; }

    [JsonProperty("list")]
    public List<PositionInfo>? List { get; set; }
}