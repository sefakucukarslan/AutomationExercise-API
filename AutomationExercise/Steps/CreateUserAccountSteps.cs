using AutomationExercise.Actions;
using AutomationExercise.Models.Requests;
using NUnit.Framework;
using System;
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

        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }

        [StepDefinition("Request parameter değerine '(.*)' değeri eklenir")]
        public void AddRequestParameter(string userParameters)
        {
            string[] parameters = userParameters.Split(',');
            userParameterRequest = new CreateUserParameterRequest
            {
                Name = parameters[0],
                Email = parameters[1],
                Password = parameters[2],
                Title = parameters[3],
                Birth_date = DateTime.ParseExact(parameters[4],"dd/MM/yyyy",CultureInfo.InvariantCulture),
                Birth_month = int.Parse(parameters[5]),
                Birth_year = int.Parse(parameters[6]),
                Firstname = parameters[7],
                Lastname = parameters[8],
                Company = parameters[9],
                Address1 = parameters[10],
                Address2 = parameters[11],
                Country = parameters[12],
                Zipcode = Int32.Parse(parameters[13]),
                State = parameters[14],
                City = parameters[15],
                Mobile_number = parameters[16]
            };
        }

        [StepDefinition(@"Create user account api çağrılır")]
        public void RunUserAccount()
        {
            action.RunUserAccount(userParameterRequest);
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
