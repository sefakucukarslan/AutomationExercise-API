using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Requests;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class SearchProductActions : BaseActions
    {
        IRestResponse restResponse;
        SearchProductResponse searchProductResponse;
        private readonly string Url = "searchProduct";

        public void RunSearchProduct(SearchProductParameterRequest requestParameter)
        {
            restResponse = ExecuteClientWithJson<SearchProductParameterRequest>(Url ,requestParameter);
            searchProductResponse = JsonSerializer.Deserialize<SearchProductResponse>(restResponse.Content);
        }

        public HttpStatusCode GetResponseStatusCode()
        {
            return restResponse.StatusCode;
        }

        public HttpStatusCode GetResponseContentResponseCode()
        {
            return searchProductResponse.ResponseCode;
        }
        public string GetResponseContentResponseMessage()
        {
            return searchProductResponse.Message;
        }
    }
}
