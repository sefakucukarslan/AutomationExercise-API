using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class DeleteUserAccountActions : BaseActions
    {
        IRestResponse restResponse;
        DeleteUserResponse userResponse;
        private readonly string Url = "deleteAccount";

        public void RunDeleteUserAccount(List<NameValuePair> nameValuePairs)
        {
            restResponse = ExecuteClientWithParameters(Url, nameValuePairs);

            userResponse = JsonSerializer.Deserialize<DeleteUserResponse>(restResponse.Content);
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
