using System;
using System.Text.Json.Serialization;

namespace AutomationExercise.Models.Requests
{
    public class CreateUserParameterRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public long Password { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("birth_date")]
        public DateTime Birth_date { get; set; }
        [JsonPropertyName("birth_month")]
        public int Birth_month { get; set; }
        [JsonPropertyName("birth_year")]
        public int Birth_year { get; set; }
        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }
        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }
        [JsonPropertyName("company")]
        public string Company { get; set; }
        [JsonPropertyName("address1")]
        public string Address1 { get; set; }
        [JsonPropertyName("address2")]
        public string Address2 { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("zipcode")]
        public long Zipcode { get; set; }
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("mobile_number")]
        public long Mobile_number { get; set; }
    }
}
