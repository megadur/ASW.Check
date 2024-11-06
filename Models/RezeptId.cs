

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ASW_Check.Model
{

    /// <summary>
    /// Schlüssel: die Rezept ID
    /// </summary>
    [DataContract(Name = "RezeptId")]
    public partial class RezeptId : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Typ
        /// </summary>
        /// <value>Gets or Sets Typ</value>
        [DataMember(Name = "typ", EmitDefaultValue = false)]
        public RezeptTyp? Typ { get; set; }

        /// <summary>
        /// Gets or Sets Rezstatus
        /// </summary>
        /// <value>Gets or Sets Rezstatus</value>
        [DataMember(Name = "rezstatus", EmitDefaultValue = false)]
        public RezStatus? Rezstatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RezeptId" /> class.
        /// </summary>
        /// <param name="typ">Gets or Sets Typ.</param>
        /// <param name="rezstatus">Gets or Sets Rezstatus.</param>
        /// <param name="apoik">Gets or Sets Apoik.</param>
        /// <param name="rezid">ApoTi Schlüssel: die Rezept ID.</param>
        /// <param name="lieferid">ApoTi Schlüssel: die Liefer ID.</param>
        /// <param name="ruid">interner Schlüssel: die Rezept RUID.</param>
        public RezeptId(RezeptTyp? typ = default, RezStatus? rezstatus = default, string apoik = default, string rezid = default, string lieferid = default, string ruid = default)
        {
            Typ = typ;
            Rezstatus = rezstatus;
            Apoik = apoik;
            Rezid = rezid;
            Lieferid = lieferid;
            Ruid = ruid;
        }

        /// <summary>
        /// Gets or Sets Apoik
        /// </summary>
        /// <value>Gets or Sets Apoik</value>
        [DataMember(Name = "apoik", EmitDefaultValue = false)]
        public string Apoik { get; set; }

        /// <summary>
        /// ApoTi Schlüssel: die Rezept ID
        /// </summary>
        /// <value>ApoTi Schlüssel: die Rezept ID</value>
        [DataMember(Name = "rezid", EmitDefaultValue = false)]
        public string Rezid { get; set; }

        /// <summary>
        /// ApoTi Schlüssel: die Liefer ID
        /// </summary>
        /// <value>ApoTi Schlüssel: die Liefer ID</value>
        [DataMember(Name = "lieferid", EmitDefaultValue = false)]
        public string Lieferid { get; set; }

        /// <summary>
        /// interner Schlüssel: die Rezept RUID
        /// </summary>
        /// <value>interner Schlüssel: die Rezept RUID</value>
        [DataMember(Name = "ruid", EmitDefaultValue = false)]
        public string Ruid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            _ = sb.Append("class RezeptId {\n");
            _ = sb.Append("  Typ: ").Append(Typ).Append("\n");
            _ = sb.Append("  Rezstatus: ").Append(Rezstatus).Append("\n");
            _ = sb.Append("  Apoik: ").Append(Apoik).Append("\n");
            _ = sb.Append("  Rezid: ").Append(Rezid).Append("\n");
            _ = sb.Append("  Lieferid: ").Append(Lieferid).Append("\n");
            _ = sb.Append("  Ruid: ").Append(Ruid).Append("\n");
            _ = sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}