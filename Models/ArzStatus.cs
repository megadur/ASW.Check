using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ASW_Check.Model
{

    /// <summary>
    /// Arz-Status des Rezepts
    /// </summary>
    /// <value>Arz-Status des Rezepts</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ArzStatus
    {
        /// <summary>
        /// Enum NEU for value: NEU
        /// </summary>
        [EnumMember(Value = "NEU")]
        NEU = 1,

        /// <summary>
        /// Enum ABGEHOLT for value: ABGEHOLT
        /// </summary>
        [EnumMember(Value = "ABGEHOLT")]
        ABGEHOLT = 2
    }
}