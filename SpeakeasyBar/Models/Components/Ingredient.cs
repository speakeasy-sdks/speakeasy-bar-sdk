
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar.Models.Components
{
    using Newtonsoft.Json;
    
    public class Ingredient
    {

        /// <summary>
        /// The name of the ingredient.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The product code of the ingredient, only available when authenticated.
        /// </summary>
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// The number of units of the ingredient in stock, only available when authenticated.
        /// </summary>
        [JsonProperty("stock")]
        public long? Stock { get; set; }

        /// <summary>
        /// The type of ingredient.
        /// </summary>
        [JsonProperty("type")]
        public IngredientType Type { get; set; } = default!;
    }
}