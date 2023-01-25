using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Requests;
using AutomationExercise.Models.Responses;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class VerifyLoginActions : BaseActions
    {
        IRestResponse restResponse;
        VerifyLoginResponse response;
        private readonly string Url = "verifyLogin";

        public void RunUserLogin(List<NameValuePair> nameValuePairs)
        {
            restResponse = ExecuteClientWithParameters(Url, nameValuePairs);

            response = JsonSerializer.Deserialize<VerifyLoginResponse>(restResponse.Content);
        }

        public HttpStatusCode GetResponseStatusCode()
        {
            return restResponse.StatusCode;
        }

        public HttpStatusCode GetResponseContentResponseCode()
        {
            return response.ResponseCode;
        }
        public string GetResponseContentResponseMessage()
        {
            return response.Message;
        }
    }
}
