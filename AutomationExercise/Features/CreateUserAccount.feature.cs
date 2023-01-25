﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomationExercise.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateUserAccount")]
    public partial class CreateUserAccountFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "CreateUserAccount.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CreateUserAccount", "Kullanici hesap kaydi", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create/Register User Account")]
        [NUnit.Framework.TestCaseAttribute("sefarslan", "s@gmail.com", "1234", "Mr.", "10/02/1996", "2", "1996", "Sefa", "Kucukarslan", "Intertech", "Seker", "Kurtulus", "Türkiye", "54100", "Adapazari", "Sakarya", "7778889911", null)]
        public void CreateRegisterUserAccount(
                    string name, 
                    string email, 
                    string password, 
                    string title, 
                    string birth_Date, 
                    string birth_Month, 
                    string birth_Year, 
                    string firstname, 
                    string lastname, 
                    string company, 
                    string address1, 
                    string address2, 
                    string country, 
                    string zipcode, 
                    string state, 
                    string city, 
                    string mobile_Number, 
                    string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("title", title);
            argumentsOfScenario.Add("birth_date", birth_Date);
            argumentsOfScenario.Add("birth_month", birth_Month);
            argumentsOfScenario.Add("birth_year", birth_Year);
            argumentsOfScenario.Add("firstname", firstname);
            argumentsOfScenario.Add("lastname", lastname);
            argumentsOfScenario.Add("company", company);
            argumentsOfScenario.Add("address1", address1);
            argumentsOfScenario.Add("address2", address2);
            argumentsOfScenario.Add("country", country);
            argumentsOfScenario.Add("zipcode", zipcode);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("mobile_number", mobile_Number);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create/Register User Account", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.And("Request Method \'POST\' olarak ayarlanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 7
 testRunner.And(string.Format("Request parameter değerine \'{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12" +
                            "},{13},{14},{15},{16}\' değeri eklenir", name, email, password, title, birth_Date, birth_Month, birth_Year, firstname, lastname, company, address1, address2, country, zipcode, state, city, mobile_Number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 8
 testRunner.And("Create user account api çağrılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 9
 testRunner.And("Response Status Code \'200\' olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 10
 testRunner.And("Response Content Response Code \'201\' olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 11
 testRunner.And("Response Content Response Message \'User created!\' olduğu görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
