using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class UserDetailActions : BaseActions
    {
        IRestResponse restResponse;
        private readonly string Url = "getUserDetailByEmail";
        UserDetailResponse UserDetailResponse;

        public void RunUserDetailWithParameters(string key, string value)
        {
            restResponse = ExecuteClient(Url + '?' + key + '=' + value);
        }

        public HttpStatusCode GetResponseStatusCode()
        {
            return restResponse.StatusCode;
        }
        public string IsNotNullResponseContent()
        {
            return restResponse.Content;
        }

        public UserDetailResponse GetResponseContentData() 
        {
            return JsonSerializer.Deserialize<UserDetailResponse>(restResponse.Content);
        }
    }
}
