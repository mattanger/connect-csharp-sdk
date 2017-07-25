/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a [CatalogModifier](#type-catalogmodifier) applied to a single line item.
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequestModifier :  IEquatable<CreateOrderRequestModifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestModifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderRequestModifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestModifier" /> class.
        /// </summary>
        /// <param name="CatalogObjectId">The catalog object id referencing [CatalogModifier](#type-catalogmodifier). (required).</param>
        public CreateOrderRequestModifier(string CatalogObjectId = default(string))
        {
            // to ensure "CatalogObjectId" is required (not null)
            if (CatalogObjectId == null)
            {
                throw new InvalidDataException("CatalogObjectId is a required property for CreateOrderRequestModifier and cannot be null");
            }
            else
            {
                this.CatalogObjectId = CatalogObjectId;
            }
        }
        
        /// <summary>
        /// The catalog object id referencing [CatalogModifier](#type-catalogmodifier).
        /// </summary>
        /// <value>The catalog object id referencing [CatalogModifier](#type-catalogmodifier).</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequestModifier {\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateOrderRequestModifier);
        }

        /// <summary>
        /// Returns true if CreateOrderRequestModifier instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequestModifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequestModifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 30)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 30.", new [] { "CatalogObjectId" });
            }

            // CatalogObjectId (string) minLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be greater than 1.", new [] { "CatalogObjectId" });
            }

            yield break;
        }
    }

}
