using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace ASW_Check.Model { 

/// <summary>
/// E-, M-, oder P-Rezept
/// </summary>
/// <value>E-, M-, oder P-Rezept</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum RezeptTyp
{
    /// <summary>
    /// Enum ERezept for value: ERezept
    /// </summary>
    [EnumMember(Value = "ERezept")]
    ERezept = 1,

    /// <summary>
    /// Enum MRezept for value: MRezept
    /// </summary>
    [EnumMember(Value = "MRezept")]
    MRezept = 2,

    /// <summary>
    /// Enum PRezept for value: PRezept
    /// </summary>
    [EnumMember(Value = "PRezept")]
    PRezept = 3
}
}