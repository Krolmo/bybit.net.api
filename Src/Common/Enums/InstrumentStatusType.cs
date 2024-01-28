namespace bybit.net.api;

public enum InstrumentStatusType
{
    Unknown, // indicates parsing error
    PreLaunch,
    Trading,
    Settling,
    Delivering,
    Closed,
}