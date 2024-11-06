

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ASW_Check.Model
{

    /// <summary>
    /// Ein Rezept mit Status mit base64 codierter Leistung
    /// </summary>
    [DataContract(Name = "Rezept")]
    public partial class Rezept : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rezept" /> class.
        /// </summary>
        /// <param name="id">Gets or Sets Id.</param>
        /// <param name="data">Gets or Sets Data.</param>
        /// <param name="status">Gets or Sets Status.</param>
        public Rezept(RezeptId id = default, string data = default, Status status = default)
        {
            Id = id;
            Data = data;
            Status = status;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <value>Gets or Sets Id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public RezeptId Id { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        /// <value>Gets or Sets Data</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <value>Gets or Sets Status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public Status Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            _ = sb.Append("class Rezept {\n");
            _ = sb.Append("  Id: ").Append(Id).Append("\n");
            _ = sb.Append("  Data: ").Append(Data).Append("\n");
            _ = sb.Append("  Status: ").Append(Status).Append("\n");
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