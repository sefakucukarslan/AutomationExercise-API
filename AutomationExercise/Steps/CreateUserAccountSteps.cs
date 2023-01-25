using AutomationExercise.Actions;
using AutomationExercise.Models.Requests;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding, Scope(Feature = "CreateUserAccount")]
    public class CreateUserAccountSteps
    {
        CreateUserAccountActions action = new CreateUserAccountActions();
        CreateUserParameterRequest userParameterRequest;
        List<NameValuePair> nameValuePairs;

        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }

        [StepDefinition("Request parameter değerine '(.*)' değeri eklenir")]
        public void AddRequestParameter(string userParameters)
        {
            string[] parameters = userParameters.Split(',');

            nameValuePairs = new List<NameValuePair> {
                new NameValuePair("name", parameters[0]),
                new NameValuePair("email", parameters[1]),
                new NameValuePair("password", parameters[2]),
                new NameValuePair("title", parameters[3]),
                new NameValuePair("birth_date", parameters[4]),
                new NameValuePair("birth_month", parameters[5]),
                new NameValuePair("birth_year", parameters[6]),
                new NameValuePair("firstname", parameters[7]),
                new NameValuePair("lastname", parameters[8]),
                new NameValuePair("company", parameters[9]),
                new NameValuePair("address1", parameters[10]),
                new NameValuePair("address2", parameters[11]),
                new NameValuePair("country", parameters[12]),
                new NameValuePair("zipcode", parameters[13]),
                new NameValuePair("state", parameters[14]),
                new NameValuePair("city", parameters[15]),
                new NameValuePair("mobile_number", parameters[16]),
            };
        }

        [StepDefinition(@"Create user account api çağrılır")]
        public void RunUserAccount()
        {
            action.RunUserAccount(nameValuePairs);
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
