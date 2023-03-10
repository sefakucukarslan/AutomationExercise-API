using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class CreateUserAccountActions : BaseActions
    {
        IRestResponse restResponse;
        CreateUserResponse userResponse;
        private readonly string Url = "createAccount";

        public void RunUserAccount(List<NameValuePair> nameValuePairs)
        {
            restResponse = ExecuteClientWithParameters(Url, nameValuePairs);

            userResponse = JsonSerializer.Deserialize<CreateUserResponse>(restResponse.Content);
        }

        public HttpStatusCode GetResponseStatusCode()
        {
            return restResponse.StatusCode;
        }

        public HttpStatusCode GetResponseContentResponseCode()
        {
            return userResponse.ResponseCode;
        }

        public string GetResponseContentResponseMessage()
        {
            return userResponse.Message;
        }
    }
}
