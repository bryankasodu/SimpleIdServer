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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UMAResourceErrorsFeature : object, Xunit.IClassFixture<UMAResourceErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAResourceErrors.feature"
#line hidden
        
        public UMAResourceErrorsFeature(UMAResourceErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAResourceErrors", "\tCheck errors returned by the /rreguri\t", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="cannot retrieve unknown UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "cannot retrieve unknown UMA resource")]
        public void CannotRetrieveUnknownUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cannot retrieve unknown UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table496 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table496.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table496.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table496.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table496.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table496, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table497 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table497.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/1\'", ((string)(null)), table497, "And ");
#line hidden
#line 19
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to add UMA resource when resource_scopes parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to add UMA resource when resource_scopes parameter is missing")]
        public void ImpossibleToAddUMAResourceWhenResource_ScopesParameterIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to add UMA resource when resource_scopes parameter is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table498 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table498.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table498.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table498.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table498.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 26
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table498, "When ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table499 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table499.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 36
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table499, "And ");
#line hidden
#line 40
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.Then("JSON \'error_description\'=\'missing parameter resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to add UMA resource when subject parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to add UMA resource when subject parameter is missing")]
        public void ImpossibleToAddUMAResourceWhenSubjectParameterIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to add UMA resource when subject parameter is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table500 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table500.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table500.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table500.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table500.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 47
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table500, "When ");
#line hidden
#line 54
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table501 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table501.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table501.AddRow(new string[] {
                            "resource_scopes",
                            "[ \"scope\" ]"});
#line 57
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table501, "And ");
#line hidden
#line 62
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("JSON \'error_description\'=\'missing parameter subject\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update UMA resource when resource_scopes is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update UMA resource when resource_scopes is missing")]
        public void ImpossibleToUpdateUMAResourceWhenResource_ScopesIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update UMA resource when resource_scopes is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 68
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table502 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table502.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table502.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table502.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table502.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 69
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table502, "When ");
#line hidden
#line 76
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table503 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table503.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 79
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/id\'", ((string)(null)), table503, "And ");
#line hidden
#line 83
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.Then("JSON \'error_description\'=\'missing parameter resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update an unknown UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update an unknown UMA resource")]
        public void ImpossibleToUpdateAnUnknownUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update an unknown UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 89
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table504 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table504.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table504.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table504.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table504.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 90
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table504, "When ");
#line hidden
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table505 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table505.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table505.AddRow(new string[] {
                            "resource_scopes",
                            "[ \"scope\" ]"});
#line 100
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/unknown\'", ((string)(null)), table505, "And ");
#line hidden
#line 105
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 109
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to remove an unknown UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to remove an unknown UMA resource")]
        public void ImpossibleToRemoveAnUnknownUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to remove an unknown UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 111
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table506 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table506.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table506.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table506.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table506.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 112
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table506, "When ");
#line hidden
#line 119
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table507 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table507.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 122
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/unknown\'", ((string)(null)), table507, "And ");
#line hidden
#line 126
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 130
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update the permissions when the permissions parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update the permissions when the permissions parameter is missing")]
        public void ImpossibleToUpdateThePermissionsWhenThePermissionsParameterIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update the permissions when the permissions parameter is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 132
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table508 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table508.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table508.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table508.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table508.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 133
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table508, "When ");
#line hidden
#line 140
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 141
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table509 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table509.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 143
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/id/permissions\'", ((string)(null)), table509, "And ");
#line hidden
#line 147
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 150
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 151
 testRunner.Then("JSON \'error_description\'=\'missing parameter permissions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update the permissions when the UMA resource doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update the permissions when the UMA resource doesn\'t exist")]
        public void ImpossibleToUpdateThePermissionsWhenTheUMAResourceDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update the permissions when the UMA resource doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 153
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table510 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table510.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table510.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table510.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table510.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 154
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table510, "When ");
#line hidden
#line 161
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 162
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table511 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table511.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table511.AddRow(new string[] {
                            "permissions",
                            "[ { claims: [ { name: \"sub\", value: \"user\" } ], scopes: [ \"scope\" ] } ]"});
#line 164
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/unknown/permissions\'", ((string)(null)), table511, "And ");
#line hidden
#line 169
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 171
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 172
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 173
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to remove permissions when the UMA resource doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to remove permissions when the UMA resource doesn\'t exist")]
        public void ImpossibleToRemovePermissionsWhenTheUMAResourceDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to remove permissions when the UMA resource doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 175
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table512 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table512.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table512.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table512.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table512.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 176
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table512, "When ");
#line hidden
#line 183
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 184
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table513 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table513.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 186
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/unknown/permissions\'", ((string)(null)), table513, "And ");
#line hidden
#line 190
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 192
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 193
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 194
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to get permissions when the UMA resource doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to get permissions when the UMA resource doesn\'t exist")]
        public void ImpossibleToGetPermissionsWhenTheUMAResourceDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to get permissions when the UMA resource doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 196
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table514 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table514.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table514.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table514.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table514.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 197
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table514, "When ");
#line hidden
#line 204
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 205
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table515 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table515.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 207
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/unknown/permissions\'", ((string)(null)), table515, "And ");
#line hidden
#line 211
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 213
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 214
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 215
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UMAResourceErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAResourceErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
