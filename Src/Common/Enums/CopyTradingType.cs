using System.Runtime.Serialization;

namespace bybit.net.api;

public enum CopyTradingType
{
    Undefined, // indicates parsing error

    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "both")]
    Both,

    [EnumMember(Value = "utaOnly")]
    UtaOnly,

    [EnumMember(Value = "normalOnly")]
    NormalOnly,
}