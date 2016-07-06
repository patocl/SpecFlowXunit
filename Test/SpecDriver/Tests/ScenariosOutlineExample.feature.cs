﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class WykopScenariosOutlineFeature : Xunit.IClassFixture<WykopScenariosOutlineFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenariosOutlineExample.feature"
#line hidden
        
        public WykopScenariosOutlineFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Wykop Scenarios Outline", "\tAs a normal person\r\n\tI want to do some actions on Wykop page\r\n\tTo check out the " +
                    "news", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(WykopScenariosOutlineFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Wykop Scenarios Outline")]
        [Xunit.TraitAttribute("Description", "All Wykop pages")]
        [Xunit.TraitAttribute("Category", "Wykop")]
        [Xunit.InlineDataAttribute("Wykop", "Wykop.pl - newsy, aktualności, gry, wiadomości, muzyka, ciekawostki, filmiki", new string[0])]
        [Xunit.InlineDataAttribute("Wykopalisko", "Wykopalisko - Wykop.pl", new string[0])]
        [Xunit.InlineDataAttribute("Hity", "Hity - Wykop.pl", new string[0])]
        [Xunit.InlineDataAttribute("Mikroblog", "Mikroblog - Wykop.pl", new string[0])]
        public virtual void AllWykopPages(string page, string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Wykop"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All Wykop pages", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I\'m on Wykop main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I go to \"{0}\" page", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("The page title is \"{0}\"", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                WykopScenariosOutlineFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                WykopScenariosOutlineFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion