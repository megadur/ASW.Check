using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace ASW_Check.Model
{

    /// <summary>
    /// Verarbeitungs-Status des Rezepts
    /// </summary>
    /// <value>Verarbeitungs-Status des Rezepts</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RezStatus
    {
        /// <summary>
        /// Enum VORPRUEFUNG for value: VOR_PRUEFUNG
        /// </summary>
        [EnumMember(Value = "VOR_PRUEFUNG")]
        VORPRUEFUNG = 1,

        /// <summary>
        /// Enum VORABRECHNUNG for value: VOR_ABRECHNUNG
        /// </summary>
        [EnumMember(Value = "VOR_ABRECHNUNG")]
        VORABRECHNUNG = 2,

        /// <summary>
        /// Enum FEHLER for value: FEHLER
        /// </summary>
        [EnumMember(Value = "FEHLER")]
        FEHLER = 3,

        /// <summary>
        /// Enum VERBESSERBAR for value: VERBESSERBAR
        /// </summary>
        [EnumMember(Value = "VERBESSERBAR")]
        VERBESSERBAR = 4,

        /// <summary>
        /// Enum RUECKWEISUNG for value: RUECKWEISUNG
        /// </summary>
        [EnumMember(Value = "RUECKWEISUNG")]
        RUECKWEISUNG = 5,

        /// <summary>
        /// Enum ABGERECHNET for value: ABGERECHNET
        /// </summary>
        [EnumMember(Value = "ABGERECHNET")]
        ABGERECHNET = 6,

        /// <summary>
        /// Enum STORNIERT for value: STORNIERT
        /// </summary>
        [EnumMember(Value = "STORNIERT")]
        STORNIERT = 7,

        /// <summary>
        /// Enum HINWEIS for value: HINWEIS
        /// </summary>
        [EnumMember(Value = "HINWEIS")]
        HINWEIS = 8,

        /// <summary>
        /// Enum ABRECHENBAR for value: ABRECHENBAR
        /// </summary>
        [EnumMember(Value = "ABRECHENBAR")]
        ABRECHENBAR = 9
    }
}