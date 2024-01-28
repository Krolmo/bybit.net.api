namespace bybit.net.api;

public enum ContractType
{
    Unknown, // indicates parsing error
    InversePerpetual,
    LinearPerpetual,
    LinearFutures,
    InverseFutures,
}