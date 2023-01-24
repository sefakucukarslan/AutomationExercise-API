using AutomationExercise.Actions;
using NUnit.Framework;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature ="BrandList")]
    public class BrandListSteps
    {
        BrandListActions action = new BrandListActions();

        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }
        
        [StepDefinition("ProductList api çağrılır")]
        public void GetAllProductListAction()
        {
            action.GetAllProductListAction();
        }

        [StepDefinition(@"Response Status Code '(.*)' olduğu görülür")]
        public void IsTrueResponseCode(HttpStatusCode statusCode)
        {
            Assert.AreEqual(action.GetResponseStatusCode(), statusCode);
        }

        [StepDefinition(@"Response Data dolu olduğu görülür")]
        public void IsNotEmptyResponseData()
        {
            Assert.NotZero(action.GetResponseDataCount());
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
