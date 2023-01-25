using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Requests;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class CreateUserAccountActions : BaseActions
    {
        IRestResponse restResponse;
        CreateUserResponse userResponse;
        private readonly string Url = "createAccount";

        public void RunUserAccount(CreateUserParameterRequest requestParameter)
        {
            restResponse = ExecuteClientWithJsonParameter<CreateUserParameterRequest>(Url, requestParameter);

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
