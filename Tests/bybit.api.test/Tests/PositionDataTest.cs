using System.Net;
using bybit.net.api;
using bybit.net.api.ApiServiceImp;
using bybit.net.api.Models;
using bybit.net.api.Models.Market.Response;
using bybit.net.api.Models.Position.Response;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using Xunit;

namespace bybit.api.test.Tests;

public class PositionDataTest
{
    [Fact]
    public async Task CheckInstruments_ResponseParsing()
    {
        var responseContent = @"{
            ""retCode"": 0,
            ""retMsg"": ""OK"",
            ""result"": {
                ""list"": [
                    {
                        ""positionIdx"": 0,
                        ""riskId"": 1,
                        ""riskLimitValue"": ""150"",
                        ""symbol"": ""BTCUSD"",
                        ""side"": ""Sell"",
                        ""size"": ""300"",
                        ""avgPrice"": ""27464.50441675"",
                        ""positionValue"": ""0.01092319"",
                        ""tradeMode"": 0,
                        ""positionStatus"": ""Normal"",
                        ""autoAddMargin"": 1,
                        ""adlRankIndicator"": 2,
                        ""leverage"": ""10"",
                        ""positionBalance"": ""0.00139186"",
                        ""markPrice"": ""28224.50"",
                        ""liqPrice"": """",
                        ""bustPrice"": ""999999.00"",
                        ""positionMM"": ""0.0000015"",
                        ""positionIM"": ""0.00010923"",
                        ""tpslMode"": ""Full"",
                        ""takeProfit"": ""0.00"",
                        ""stopLoss"": ""0.00"",
                        ""trailingStop"": ""0.00"",
                        ""unrealisedPnl"": ""-0.00029413"",
                        ""cumRealisedPnl"": ""-0.00096902"",
                        ""seq"": 5723621632,
                        ""isReduceOnly"": false,
                        ""mmrSysUpdateTime"": """",
                        ""leverageSysUpdatedTime"": """",
                        ""createdTime"": ""1676538056258"",
                        ""updatedTime"": ""1697673600012""
                    }
                ],
                ""nextPageCursor"": """",
                ""category"": ""inverse""
            },
            ""retExtInfo"": {},
            ""time"": 1697684980172
        }";
        var mockMessageHandler = new Mock<HttpMessageHandler>();
        mockMessageHandler.Protected()
            .SetupSendAsync("/v5/position/list", HttpMethod.Get)
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(responseContent),
            });

        var httpClient = new HttpClient(mockMessageHandler.Object)
        {
            BaseAddress = new Uri("https://api.bybit.com") // Set a valid base address here
        };

        BybitPositionService market = new(httpClient, "abcdefghijklmn", "1234567890");

        var result = await market.GetPositionInfo(Category.INVERSE, "BTCUSD");
        Assert.NotNull(result);
        var parsed = JsonConvert.DeserializeObject<GeneralResponse<PositionsResult>>(result);
        Assert.NotNull(parsed);
        Assert.Equal(0, parsed.RetCode);
        Assert.Equal("OK", parsed.RetMsg);
        Assert.NotNull(parsed.Result);
        Assert.NotNull(parsed.Result.List);

        // Check all fields in string response correspond to object result
        Assert.Equal(responseContent, result);
        Assert.Equal(ProductType.Inverse, parsed.Result.Category);
        Assert.Equal("BTCUSD", parsed.Result.List[0].Symbol);
        Assert.Equal(SideType.Sell, parsed.Result.List[0].Side);
        Assert.Equal(300, parsed.Result.List[0].Size);
        Assert.Equal(27464.50441675m, parsed.Result.List[0].AvgPrice);
        Assert.Equal(0.01092319m, parsed.Result.List[0].PositionValue);
        Assert.Equal(TradeModeType.CrossMargin, parsed.Result.List[0].TradeMode);
        Assert.Equal(PositionStatusType.Normal, parsed.Result.List[0].PositionStatus);
        Assert.Equal(BitType.True, parsed.Result.List[0].AutoAddMargin);
        Assert.Equal(2, parsed.Result.List[0].AdlRankIndicator);
        Assert.Equal(10, parsed.Result.List[0].Leverage);
        Assert.Equal(0.00139186m, parsed.Result.List[0].PositionBalance);
        Assert.Equal(28224.50m, parsed.Result.List[0].MarkPrice);
        Assert.Null(parsed.Result.List[0].LiqPrice);
        Assert.Equal(999999.00m, parsed.Result.List[0].BustPrice);
        Assert.Equal(0.0000015m, parsed.Result.List[0].PositionMm);
        Assert.Equal(0.00010923m, parsed.Result.List[0].PositionIm);
        Assert.Equal(0.00m, parsed.Result.List[0].TakeProfit);
        Assert.Equal(0.00m, parsed.Result.List[0].StopLoss);
        Assert.Equal(0.00m, parsed.Result.List[0].TrailingStop);
        Assert.Equal(-0.00029413m, parsed.Result.List[0].UnrealisedPnl);
        Assert.Equal(-0.00096902m, parsed.Result.List[0].CumRealisedPnl);
        Assert.Equal(5723621632, parsed.Result.List[0].Seq);
        Assert.False(parsed.Result.List[0].IsReduceOnly);
        Assert.Equal(1676538056258, parsed.Result.List[0].CreatedTime);
        Assert.Equal(1697673600012, parsed.Result.List[0].UpdatedTime);
    }
}