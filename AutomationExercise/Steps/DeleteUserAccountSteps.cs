using AutomationExercise.Actions;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding, Scope(Feature = "DeleteUserAccount")]
    public class DeleteUserAccountSteps
    {
        DeleteUserAccountActions action = new DeleteUserAccountActions();
        List<NameValuePair> nameValuePairs;

        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }

        [StepDefinition("Request parameter değerine '(.*)' ve '(.*)' değeri eklenir")]
        public void AddRequestParameter(string email, string password)
        {
            nameValuePairs = new List<NameValuePair>();
            nameValuePairs.Add(new NameValuePair("email", email));
            nameValuePairs.Add(new NameValuePair("password", password));
        }

        [StepDefinition(@"Delete user account api çağrılır")]
        public void RunDeleteUserAccount()
        {
            action.RunDeleteUserAccount(nameValuePairs);
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
