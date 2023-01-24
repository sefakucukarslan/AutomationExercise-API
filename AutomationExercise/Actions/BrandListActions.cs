using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class BrandListActions : BaseActions
    {
        IRestResponse restResponse;
        BrandListResponse brandListResponse;
        private readonly string Url = "brandsList";

        public void GetAllProductListAction()
        {
            restResponse = ExecuteClient(Url);
            brandListResponse = JsonSerializer.Deserialize<BrandListResponse>(restResponse.Content);
        }

        public HttpStatusCode GetResponseStatusCode()
        {
            return restResponse.StatusCode;
        }

        public int GetResponseDataCount()
        {
            return restResponse.Content.Count();
        }

        public HttpStatusCode GetResponseContentResponseCode()
        {
            return brandListResponse.ResponseCode;
        }
        
        public string GetResponseContentResponseMessage()
        {
            return brandListResponse.Message;
        }
    }
}
