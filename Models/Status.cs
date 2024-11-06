
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ASW_Check.Model
{

    /// <summary>
    /// Status des Rezepts
    /// </summary>
    [DataContract(Name = "Status")]
    public partial class Status : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Rezstatus
        /// </summary>
        /// <value>Gets or Sets Rezstatus</value>
        [DataMember(Name = "rezstatus", EmitDefaultValue = false)]
        public RezStatus? Rezstatus { get; set; }

        /// <summary>
        /// Gets or Sets Arzstatus
        /// </summary>
        /// <value>Gets or Sets Arzstatus</value>
        [DataMember(Name = "arzstatus", EmitDefaultValue = false)]
        public ArzStatus? Arzstatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        /// <param name="rezstatus">Gets or Sets Rezstatus.</param>
        /// <param name="arzstatus">Gets or Sets Arzstatus.</param>
        public Status(RezStatus? rezstatus = default, ArzStatus? arzstatus = default)
        {
            Rezstatus = rezstatus;
            Arzstatus = arzstatus;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            _ = sb.Append("class Status {\n");
            _ = sb.Append("  Rezstatus: ").Append(Rezstatus).Append("\n");
            _ = sb.Append("  Arzstatus: ").Append(Arzstatus).Append("\n");
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