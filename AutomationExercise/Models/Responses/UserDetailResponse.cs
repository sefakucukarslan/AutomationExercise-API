using System.Text.Json.Serialization;

namespace AutomationExercise.Models.Responses
{
    public class UserDetailResponse
    {
        [JsonPropertyName("user")]
        public User User { get; set; }
    }

    public class User
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
