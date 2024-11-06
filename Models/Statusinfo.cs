

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ASW_Check.Model
{

    /// <summary>
    /// Statusinfo
    /// </summary>
    [DataContract(Name = "Statusinfo")]
    public partial class Statusinfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statusinfo" /> class.
        /// </summary>
        /// <param name="status">Rezeptstatus.</param>
        /// <param name="fcode">Gets or Sets Fcode.</param>
        /// <param name="fstatus">Gets or Sets Fstatus.</param>
        /// <param name="fkommentar">Gets or Sets Fkommentar.</param>
        /// <param name="ftcode">Gets or Sets Ftcode.</param>
        /// <param name="posnr">Gets or Sets Posnr.</param>
        /// <param name="fkurztext">Gets or Sets Fkurztext.</param>
        /// <param name="error">Gets or Sets Error.</param>
        public Statusinfo(string status = default, string fcode = default, string fstatus = default, string fkommentar = default, string ftcode = default, string posnr = default, string fkurztext = default, Error error = default)
        {
            Status = status ?? string.Empty;
            Fcode = fcode ?? string.Empty;
            Fstatus = fstatus ?? string.Empty;
            Fkommentar = fkommentar ?? string.Empty;
            Ftcode = ftcode ?? string.Empty;
            Posnr = posnr ?? string.Empty;
            Fkurztext = fkurztext ?? string.Empty;
            Error = error ?? new Error();
        }

        /// <summary>
        /// Rezeptstatus
        /// </summary>
        /// <value>Rezeptstatus</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Fcode
        /// </summary>
        /// <value>Gets or Sets Fcode</value>
        [DataMember(Name = "fcode", EmitDefaultValue = false)]
        public string Fcode { get; set; }

        /// <summary>
        /// Gets or Sets Fstatus
        /// </summary>
        /// <value>Gets or Sets Fstatus</value>
        [DataMember(Name = "fstatus", EmitDefaultValue = false)]
        public string Fstatus { get; set; }

        /// <summary>
        /// Gets or Sets Fkommentar
        /// </summary>
        /// <value>Gets or Sets Fkommentar</value>
        [DataMember(Name = "fkommentar", EmitDefaultValue = false)]
        public string Fkommentar { get; set; }

        /// <summary>
        /// Gets or Sets Ftcode
        /// </summary>
        /// <value>Gets or Sets Ftcode</value>
        [DataMember(Name = "ftcode", EmitDefaultValue = false)]
        public string Ftcode { get; set; }

        /// <summary>
        /// Gets or Sets Posnr
        /// </summary>
        /// <value>Gets or Sets Posnr</value>
        [DataMember(Name = "posnr", EmitDefaultValue = false)]
        public string Posnr { get; set; }

        /// <summary>
        /// Gets or Sets Fkurztext
        /// </summary>
        /// <value>Gets or Sets Fkurztext</value>
        [DataMember(Name = "fkurztext", EmitDefaultValue = false)]
        public string Fkurztext { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        /// <value>Gets or Sets Error</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public Error Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            _ = sb.Append("class Statusinfo {\n");
            _ = sb.Append("  Status: ").Append(Status).Append("\n");
            _ = sb.Append("  Fcode: ").Append(Fcode).Append("\n");
            _ = sb.Append("  Fstatus: ").Append(Fstatus).Append("\n");
            _ = sb.Append("  Fkommentar: ").Append(Fkommentar).Append("\n");
            _ = sb.Append("  Ftcode: ").Append(Ftcode).Append("\n");
            _ = sb.Append("  Posnr: ").Append(Posnr).Append("\n");
            _ = sb.Append("  Fkurztext: ").Append(Fkurztext).Append("\n");
            _ = sb.Append("  Error: ").Append(Error).Append("\n");
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
    }
}