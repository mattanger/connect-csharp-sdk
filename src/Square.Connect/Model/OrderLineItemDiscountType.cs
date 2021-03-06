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
    /// Indicates how the discount is applied to the associated line item or order.
    /// </summary>
    /// <value>Indicates how the discount is applied to the associated line item or order.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderLineItemDiscountType
    {
        
        /// <summary>
        /// Enum UNKNOWN for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
        
        /// <summary>
        /// Enum FIXEDPERCENTAGE for "FIXED_PERCENTAGE"
        /// </summary>
        [EnumMember(Value = "FIXED_PERCENTAGE")]
        FIXEDPERCENTAGE,
        
        /// <summary>
        /// Enum FIXEDAMOUNT for "FIXED_AMOUNT"
        /// </summary>
        [EnumMember(Value = "FIXED_AMOUNT")]
        FIXEDAMOUNT,
        
        /// <summary>
        /// Enum VARIABLEPERCENTAGE for "VARIABLE_PERCENTAGE"
        /// </summary>
        [EnumMember(Value = "VARIABLE_PERCENTAGE")]
        VARIABLEPERCENTAGE,
        
        /// <summary>
        /// Enum VARIABLEAMOUNT for "VARIABLE_AMOUNT"
        /// </summary>
        [EnumMember(Value = "VARIABLE_AMOUNT")]
        VARIABLEAMOUNT
    }

}
