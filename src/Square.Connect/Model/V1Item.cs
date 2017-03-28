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
    /// V1Item
    /// </summary>
    [DataContract]
    public partial class V1Item :  IEquatable<V1Item>, IValidatableObject
    {
        /// <summary>
        /// The item's type. This value is NORMAL for almost all items.
        /// </summary>
        /// <value>The item's type. This value is NORMAL for almost all items.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum NORMAL for "NORMAL"
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMAL,
            
            /// <summary>
            /// Enum GIFTCARD for "GIFT_CARD"
            /// </summary>
            [EnumMember(Value = "GIFT_CARD")]
            GIFTCARD,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// The color of the discount's display label in Square Register, if not the default color. The default color is 9da2a6.
        /// </summary>
        /// <value>The color of the discount's display label in Square Register, if not the default color. The default color is 9da2a6.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            
            /// <summary>
            /// Enum _9da2a6 for "9da2a6"
            /// </summary>
            [EnumMember(Value = "9da2a6")]
            _9da2a6,
            
            /// <summary>
            /// Enum _4ab200 for "4ab200"
            /// </summary>
            [EnumMember(Value = "4ab200")]
            _4ab200,
            
            /// <summary>
            /// Enum _0b8000 for "0b8000"
            /// </summary>
            [EnumMember(Value = "0b8000")]
            _0b8000,
            
            /// <summary>
            /// Enum _2952cc for "2952cc"
            /// </summary>
            [EnumMember(Value = "2952cc")]
            _2952cc,
            
            /// <summary>
            /// Enum A82ee5 for "a82ee5"
            /// </summary>
            [EnumMember(Value = "a82ee5")]
            A82ee5,
            
            /// <summary>
            /// Enum E5457a for "e5457a"
            /// </summary>
            [EnumMember(Value = "e5457a")]
            E5457a,
            
            /// <summary>
            /// Enum B21212 for "b21212"
            /// </summary>
            [EnumMember(Value = "b21212")]
            B21212,
            
            /// <summary>
            /// Enum _593c00 for "593c00"
            /// </summary>
            [EnumMember(Value = "593c00")]
            _593c00,
            
            /// <summary>
            /// Enum E5BF00 for "e5BF00"
            /// </summary>
            [EnumMember(Value = "e5BF00")]
            E5BF00
        }

        /// <summary>
        /// Indicates whether the item is viewable from the merchant's online store (PUBLIC) or PRIVATE.
        /// </summary>
        /// <value>Indicates whether the item is viewable from the merchant's online store (PUBLIC) or PRIVATE.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            
            /// <summary>
            /// Enum PUBLIC for "PUBLIC"
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            PUBLIC,
            
            /// <summary>
            /// Enum PRIVATE for "PRIVATE"
            /// </summary>
            [EnumMember(Value = "PRIVATE")]
            PRIVATE
        }

        /// <summary>
        /// The item's type. This value is NORMAL for almost all items.
        /// </summary>
        /// <value>The item's type. This value is NORMAL for almost all items.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The color of the discount's display label in Square Register, if not the default color. The default color is 9da2a6.
        /// </summary>
        /// <value>The color of the discount's display label in Square Register, if not the default color. The default color is 9da2a6.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Indicates whether the item is viewable from the merchant's online store (PUBLIC) or PRIVATE.
        /// </summary>
        /// <value>Indicates whether the item is viewable from the merchant's online store (PUBLIC) or PRIVATE.</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Item" /> class.
        /// </summary>
        /// <param name="Id">The item&#39;s ID. Must be unique among all entity IDs ever provided on behalf of the merchant. You can never reuse an ID. This value can include alphanumeric characters, dashes (-), and underscores (_)..</param>
        /// <param name="Name">The item&#39;s name..</param>
        /// <param name="Description">The item&#39;s description..</param>
        /// <param name="Type">The item&#39;s type. This value is NORMAL for almost all items..</param>
        /// <param name="Color">The color of the discount&#39;s display label in Square Register, if not the default color. The default color is 9da2a6..</param>
        /// <param name="Abbreviation">The text of the item&#39;s display label in Square Register. Only up to the first five characters of the string are used..</param>
        /// <param name="Visibility">Indicates whether the item is viewable from the merchant&#39;s online store (PUBLIC) or PRIVATE..</param>
        /// <param name="AvailableOnline">If true, the item can be added to shipping orders from the merchant&#39;s online store..</param>
        /// <param name="MasterImage">The item&#39;s master image, if any..</param>
        /// <param name="Category">The category the item belongs to, if any..</param>
        /// <param name="Variations">The item&#39;s variations. You must specify at least one variation..</param>
        /// <param name="ModifierLists">The modifier lists that apply to the item, if any..</param>
        /// <param name="Fees">The fees that apply to the item, if any..</param>
        /// <param name="Taxable">Deprecated. This field is not used..</param>
        public V1Item(string Id = default(string), string Name = default(string), string Description = default(string), TypeEnum? Type = default(TypeEnum?), ColorEnum? Color = default(ColorEnum?), string Abbreviation = default(string), VisibilityEnum? Visibility = default(VisibilityEnum?), string AvailableOnline = default(string), V1ItemImage MasterImage = default(V1ItemImage), V1Category Category = default(V1Category), List<V1Variation> Variations = default(List<V1Variation>), List<V1Variation> ModifierLists = default(List<V1Variation>), List<V1Fee> Fees = default(List<V1Fee>), bool? Taxable = default(bool?))
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.Color = Color;
            this.Abbreviation = Abbreviation;
            this.Visibility = Visibility;
            this.AvailableOnline = AvailableOnline;
            this.MasterImage = MasterImage;
            this.Category = Category;
            this.Variations = Variations;
            this.ModifierLists = ModifierLists;
            this.Fees = Fees;
            this.Taxable = Taxable;
        }
        
        /// <summary>
        /// The item&#39;s ID. Must be unique among all entity IDs ever provided on behalf of the merchant. You can never reuse an ID. This value can include alphanumeric characters, dashes (-), and underscores (_).
        /// </summary>
        /// <value>The item&#39;s ID. Must be unique among all entity IDs ever provided on behalf of the merchant. You can never reuse an ID. This value can include alphanumeric characters, dashes (-), and underscores (_).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The item&#39;s name.
        /// </summary>
        /// <value>The item&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The item&#39;s description.
        /// </summary>
        /// <value>The item&#39;s description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The text of the item&#39;s display label in Square Register. Only up to the first five characters of the string are used.
        /// </summary>
        /// <value>The text of the item&#39;s display label in Square Register. Only up to the first five characters of the string are used.</value>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }
        /// <summary>
        /// If true, the item can be added to shipping orders from the merchant&#39;s online store.
        /// </summary>
        /// <value>If true, the item can be added to shipping orders from the merchant&#39;s online store.</value>
        [DataMember(Name="available_online", EmitDefaultValue=false)]
        public string AvailableOnline { get; set; }
        /// <summary>
        /// The item&#39;s master image, if any.
        /// </summary>
        /// <value>The item&#39;s master image, if any.</value>
        [DataMember(Name="master_image", EmitDefaultValue=false)]
        public V1ItemImage MasterImage { get; set; }
        /// <summary>
        /// The category the item belongs to, if any.
        /// </summary>
        /// <value>The category the item belongs to, if any.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public V1Category Category { get; set; }
        /// <summary>
        /// The item&#39;s variations. You must specify at least one variation.
        /// </summary>
        /// <value>The item&#39;s variations. You must specify at least one variation.</value>
        [DataMember(Name="variations", EmitDefaultValue=false)]
        public List<V1Variation> Variations { get; set; }
        /// <summary>
        /// The modifier lists that apply to the item, if any.
        /// </summary>
        /// <value>The modifier lists that apply to the item, if any.</value>
        [DataMember(Name="modifier_lists", EmitDefaultValue=false)]
        public List<V1Variation> ModifierLists { get; set; }
        /// <summary>
        /// The fees that apply to the item, if any.
        /// </summary>
        /// <value>The fees that apply to the item, if any.</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public List<V1Fee> Fees { get; set; }
        /// <summary>
        /// Deprecated. This field is not used.
        /// </summary>
        /// <value>Deprecated. This field is not used.</value>
        [DataMember(Name="taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Item {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  AvailableOnline: ").Append(AvailableOnline).Append("\n");
            sb.Append("  MasterImage: ").Append(MasterImage).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Variations: ").Append(Variations).Append("\n");
            sb.Append("  ModifierLists: ").Append(ModifierLists).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
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
            return this.Equals(obj as V1Item);
        }

        /// <summary>
        /// Returns true if V1Item instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Item other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Abbreviation == other.Abbreviation ||
                    this.Abbreviation != null &&
                    this.Abbreviation.Equals(other.Abbreviation)
                ) && 
                (
                    this.Visibility == other.Visibility ||
                    this.Visibility != null &&
                    this.Visibility.Equals(other.Visibility)
                ) && 
                (
                    this.AvailableOnline == other.AvailableOnline ||
                    this.AvailableOnline != null &&
                    this.AvailableOnline.Equals(other.AvailableOnline)
                ) && 
                (
                    this.MasterImage == other.MasterImage ||
                    this.MasterImage != null &&
                    this.MasterImage.Equals(other.MasterImage)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Variations == other.Variations ||
                    this.Variations != null &&
                    this.Variations.SequenceEqual(other.Variations)
                ) && 
                (
                    this.ModifierLists == other.ModifierLists ||
                    this.ModifierLists != null &&
                    this.ModifierLists.SequenceEqual(other.ModifierLists)
                ) && 
                (
                    this.Fees == other.Fees ||
                    this.Fees != null &&
                    this.Fees.SequenceEqual(other.Fees)
                ) && 
                (
                    this.Taxable == other.Taxable ||
                    this.Taxable != null &&
                    this.Taxable.Equals(other.Taxable)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Abbreviation != null)
                    hash = hash * 59 + this.Abbreviation.GetHashCode();
                if (this.Visibility != null)
                    hash = hash * 59 + this.Visibility.GetHashCode();
                if (this.AvailableOnline != null)
                    hash = hash * 59 + this.AvailableOnline.GetHashCode();
                if (this.MasterImage != null)
                    hash = hash * 59 + this.MasterImage.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Variations != null)
                    hash = hash * 59 + this.Variations.GetHashCode();
                if (this.ModifierLists != null)
                    hash = hash * 59 + this.ModifierLists.GetHashCode();
                if (this.Fees != null)
                    hash = hash * 59 + this.Fees.GetHashCode();
                if (this.Taxable != null)
                    hash = hash * 59 + this.Taxable.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}