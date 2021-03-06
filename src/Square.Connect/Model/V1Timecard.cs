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
    /// Represents a timecard for an employee.
    /// </summary>
    [DataContract]
    public partial class V1Timecard :  IEquatable<V1Timecard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Timecard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1Timecard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Timecard" /> class.
        /// </summary>
        /// <param name="EmployeeId">The ID of the employee the timecard is associated with. (required).</param>
        /// <param name="ClockinTime">The clock-in time for the timecard, in ISO 8601 format..</param>
        /// <param name="ClockoutTime">The clock-out time for the timecard, in ISO 8601 format. Provide this value only if importing timecard information from another system..</param>
        /// <param name="ClockinLocationId">The ID of the location the employee clocked in from, if any..</param>
        /// <param name="ClockoutLocationId">The ID of the location the employee clocked out from. Provide this value only if importing timecard information from another system..</param>
        public V1Timecard(string EmployeeId = default(string), string ClockinTime = default(string), string ClockoutTime = default(string), string ClockinLocationId = default(string), string ClockoutLocationId = default(string))
        {
            // to ensure "EmployeeId" is required (not null)
            if (EmployeeId == null)
            {
                throw new InvalidDataException("EmployeeId is a required property for V1Timecard and cannot be null");
            }
            else
            {
                this.EmployeeId = EmployeeId;
            }
            this.ClockinTime = ClockinTime;
            this.ClockoutTime = ClockoutTime;
            this.ClockinLocationId = ClockinLocationId;
            this.ClockoutLocationId = ClockoutLocationId;
        }
        
        /// <summary>
        /// The timecard&#39;s unique ID.
        /// </summary>
        /// <value>The timecard&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The ID of the employee the timecard is associated with.
        /// </summary>
        /// <value>The ID of the employee the timecard is associated with.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// If true, the timecard was deleted by the merchant, and it is no longer valid.
        /// </summary>
        /// <value>If true, the timecard was deleted by the merchant, and it is no longer valid.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; private set; }
        /// <summary>
        /// The clock-in time for the timecard, in ISO 8601 format.
        /// </summary>
        /// <value>The clock-in time for the timecard, in ISO 8601 format.</value>
        [DataMember(Name="clockin_time", EmitDefaultValue=false)]
        public string ClockinTime { get; set; }
        /// <summary>
        /// The clock-out time for the timecard, in ISO 8601 format. Provide this value only if importing timecard information from another system.
        /// </summary>
        /// <value>The clock-out time for the timecard, in ISO 8601 format. Provide this value only if importing timecard information from another system.</value>
        [DataMember(Name="clockout_time", EmitDefaultValue=false)]
        public string ClockoutTime { get; set; }
        /// <summary>
        /// The ID of the location the employee clocked in from, if any.
        /// </summary>
        /// <value>The ID of the location the employee clocked in from, if any.</value>
        [DataMember(Name="clockin_location_id", EmitDefaultValue=false)]
        public string ClockinLocationId { get; set; }
        /// <summary>
        /// The ID of the location the employee clocked out from. Provide this value only if importing timecard information from another system.
        /// </summary>
        /// <value>The ID of the location the employee clocked out from. Provide this value only if importing timecard information from another system.</value>
        [DataMember(Name="clockout_location_id", EmitDefaultValue=false)]
        public string ClockoutLocationId { get; set; }
        /// <summary>
        /// The time when the timecard was created, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the timecard was created, in ISO 8601 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; private set; }
        /// <summary>
        /// The time when the timecard was most recently updated, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the timecard was most recently updated, in ISO 8601 format.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Timecard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  ClockinTime: ").Append(ClockinTime).Append("\n");
            sb.Append("  ClockoutTime: ").Append(ClockoutTime).Append("\n");
            sb.Append("  ClockinLocationId: ").Append(ClockinLocationId).Append("\n");
            sb.Append("  ClockoutLocationId: ").Append(ClockoutLocationId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as V1Timecard);
        }

        /// <summary>
        /// Returns true if V1Timecard instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Timecard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Timecard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) && 
                (
                    this.ClockinTime == other.ClockinTime ||
                    this.ClockinTime != null &&
                    this.ClockinTime.Equals(other.ClockinTime)
                ) && 
                (
                    this.ClockoutTime == other.ClockoutTime ||
                    this.ClockoutTime != null &&
                    this.ClockoutTime.Equals(other.ClockoutTime)
                ) && 
                (
                    this.ClockinLocationId == other.ClockinLocationId ||
                    this.ClockinLocationId != null &&
                    this.ClockinLocationId.Equals(other.ClockinLocationId)
                ) && 
                (
                    this.ClockoutLocationId == other.ClockoutLocationId ||
                    this.ClockoutLocationId != null &&
                    this.ClockoutLocationId.Equals(other.ClockoutLocationId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                if (this.ClockinTime != null)
                    hash = hash * 59 + this.ClockinTime.GetHashCode();
                if (this.ClockoutTime != null)
                    hash = hash * 59 + this.ClockoutTime.GetHashCode();
                if (this.ClockinLocationId != null)
                    hash = hash * 59 + this.ClockinLocationId.GetHashCode();
                if (this.ClockoutLocationId != null)
                    hash = hash * 59 + this.ClockoutLocationId.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
