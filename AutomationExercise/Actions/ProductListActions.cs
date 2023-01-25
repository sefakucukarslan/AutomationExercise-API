using AutomationExercise.Actions.Base;
using AutomationExercise.Models.Responses;
using RestSharp;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace AutomationExercise.Actions
{
    public class ProductListActions : BaseActions
    {
        IRestResponse restResponse;
        ProductListResponse productListResponse;
        private readonly string Url = "productsList";
        
        public void GetAllProductList() 
        {
            restResponse = ExecuteClient(Url);
            productListResponse = JsonSerializer.Deserialize<ProductListResponse>(restResponse.Content);
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
            return productListResponse.ResponseCode;
        }

        public string GetResponseContentResponseMessage()
        {
            return productListResponse.Message;
        }
    }
}
