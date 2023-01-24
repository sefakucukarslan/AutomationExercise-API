using System.Net;
using System.Text.Json.Serialization;

namespace AutomationExercise.Models.Responses
{
    public class BrandListResponse
    {
        [JsonPropertyName("responseCode")]
        public HttpStatusCode ResponseCode { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
