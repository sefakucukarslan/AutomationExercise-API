using AutomationExercise.Actions;
using AutomationExercise.Models.Requests;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding, Scope(Feature = "VerifyLogin")]
    public class VerifyLoginSteps
    {
        VerifyLoginActions action = new VerifyLoginActions();
        List<NameValuePair> nameValuePairs;

        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }

        [StepDefinition("Request parameter değerine '(.*)' ve '(.*)' değeri eklenir")]
        public void AddRequestParameter(string email, string password)
        {
            nameValuePairs = new List<NameValuePair> {
                new NameValuePair("email", email),
                new NameValuePair("password", password)
            };
            
        }

        [StepDefinition("Verify login api çağrılır")]
        public void RunUserLogin()
        {
            action.RunUserLogin(nameValuePairs);
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
