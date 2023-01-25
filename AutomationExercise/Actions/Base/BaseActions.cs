using AutomationExercise.Models.Requests;
using RestSharp;
using System;
using System.Text.Json;

namespace AutomationExercise.Actions.Base
{
    public class BaseActions
    {
        RestClient client = new RestClient();
        RestRequest request;
        protected readonly static string URL = "https://automationexercise.com/api/";
        private Method methodType;

        public void SetMethodType(string type)
        {
            if (type == "GET")
            {
                methodType = Method.GET;
            }
            else if (type == "POST")
            {
                methodType = Method.POST;
            }
            else if (type == "PUT")
            {
                methodType = Method.PUT;
            }
            else if (type == "DELETE")
            {
                methodType = Method.DELETE;
            }
            else
            {
                throw new Exception("Hatalı Method Tipi : " + type);
            }

        }

        public IRestResponse ExecuteClient(string url)
        {
            client.BaseUrl = new Uri(URL + url);
            request = new RestRequest(methodType);
            return client.Execute(request);
        }
        
        public IRestResponse ExecuteClientWithJsonParameter<T>(string url , T parameterRequest)
        {
            client.BaseUrl = new Uri(URL + url);
            request = new RestRequest(methodType);
            request.AddJsonBody(JsonSerializer.Serialize(parameterRequest));
            return client.Execute(request);
        }

    }
}
