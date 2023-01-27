using AutomationExercise.Actions;
using NUnit.Framework;
using RestSharp;
using System.Net;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature ="UserDetailByEmail")]
    public class UserDetailSteps
    {
        UserDetailActions action = new UserDetailActions();
        NameValuePair pair;

        [StepDefinition("Request Method '(.*)' olarak ayarlanır")]
        public void SetMethodType(string type)
        {
            action.SetMethodType(type);
        }
        
        [StepDefinition("Request parameter '(.*)' değerine '(.*)' değeri eklenir")]
        public void AddGetRequestParameter(string name, string value)
        {
            pair = new NameValuePair(name, value);
        }
        
        [StepDefinition("Get user account detail by email api çağrılır")]
        public void RunUserDetailWithParameters()
        {
            action.RunUserDetailWithParameters(pair.Name, pair.Value);
        }

        [StepDefinition(@"Response Status Code '(.*)' olduğu görülür")]
        public void IsTrueResponseCode(HttpStatusCode statusCode)
        {
            Assert.AreEqual(action.GetResponseStatusCode(), statusCode);
        }
        
        [StepDefinition(@"Dönen verinin dolu olduğu görülür")]
        public void IsNotNullResponseContent()
        {
            Assert.IsNotNull(action.IsNotNullResponseContent());
            Assert.IsNotEmpty(action.IsNotNullResponseContent());
        }
        
        [StepDefinition(@"Dönen veride email değerinin '(.*)' olduğu görülür")]
        public void IsTrueResponseData(string value)
        {
            Assert.AreEqual(action.GetResponseContentData().User.Email, value);
        }

    }
}
