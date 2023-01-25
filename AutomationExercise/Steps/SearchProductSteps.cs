using AutomationExercise.Actions;
using AutomationExercise.Models.Requests;
using NUnit.Framework;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature ="SearchProduct")]
    public class SearchProductSteps
    {
        SearchProductActions action = new SearchProductActions();
        SearchProductParameterRequest productParameterRequest;
        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }

        [StepDefinition("Request parameter değerine '(.*)' değeri eklenir")]
        public void AddRequestParameter(string value)
        {
            productParameterRequest = new SearchProductParameterRequest { search_product =  value};
        }
        
        [StepDefinition("Search Product api çağrılır")]
        public void RunSearchProduct()
        {
            action.RunSearchProduct(productParameterRequest);
        }

        [StepDefinition(@"Response Status Code '(.*)' olduğu görülür")]
        public void IsTrueResponseCode(HttpStatusCode statusCode)
        {
            Assert.AreEqual(action.GetResponseStatusCode(), statusCode);
        }
        
        [StepDefinition(@"Response Content Response Code '(.*)' olduğu görülür")]
        public void IsTrueResponseContentResponseCode(HttpStatusCode responseCode)
        {
            Assert.AreEqual(action.GetResponseContentResponseCode(), responseCode);
        }

        [StepDefinition(@"Response Content Response Message '(.*)' olduğu görülür")]
        public void IsTrueResponseContentResponseMessage(string responseMessage)
        {
            Assert.AreEqual(action.GetResponseContentResponseMessage(), responseMessage);
        }
    }
}
