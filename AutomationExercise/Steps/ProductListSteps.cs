using AutomationExercise.Actions;
using NUnit.Framework;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature ="ProductList")]
    public class ProductListSteps
    {
        ProductListActions action = new ProductListActions();

        [Given(@"Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }

        [Given(@"ProductList api çağrılır")]
        public void GetAllProductListAction()
        {
            action.GetAllProductListAction();
        }

        [Given(@"Response Status Code '(.*)' olduğu görülür")]
        public void IsTrueResponseCode(HttpStatusCode statusCode)
        {
            Assert.AreEqual(action.GetResponseStatusCode(), statusCode);
        }

        [Given(@"Response Data dolu olduğu görülür")]
        public void IsNotEmptyResponseData()
        {
            Assert.NotZero(action.GetResponseDataCount());
        }
        
        [Given(@"Response Content Response Code '(.*)' olduğu görülür")]
        public void IsTrueResponseContentResponseCode(HttpStatusCode responseCode)
        {
            Assert.AreEqual(action.GetResponseContentResponseCode(), responseCode);
        }
        
        [Given(@"Response Content Response Message '(.*)' olduğu görülür")]
        public void IsTrueResponseContentResponseMessage(string responseMessage)
        {
            Assert.AreEqual(action.GetResponseContentResponseMessage(), responseMessage);
        }
    }
}
