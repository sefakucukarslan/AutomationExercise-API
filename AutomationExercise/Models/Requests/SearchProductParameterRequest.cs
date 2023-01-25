using System.Text.Json.Serialization;

namespace AutomationExercise.Models.Requests
{
    public class SearchProductParameterRequest
    {
        [JsonPropertyName("search_product")]
        public string Search_product { get; set; }
    }
}
