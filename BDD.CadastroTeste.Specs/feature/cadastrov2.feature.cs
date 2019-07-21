﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDD.CadastroTeste.Specs.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CadastroFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "cadastrov2.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Cadastro", "    Novo usuário \r\n    Irá se cadastrar para utilizar as funcionalidades\r\n    Ass" +
                    "im posso buscar outroas pessoas e ser encontrado ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Cadastro")))
            {
                global::BDD.CadastroTeste.Specs.Feature.CadastroFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Usuario cadastrado com sucesso")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro")]
        public virtual void UsuarioCadastradoComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Usuario cadastrado com sucesso", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
    testRunner.Given("Usuário não cadastrado acesso a página inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Ultimo nome",
                        "Email"});
            table1.AddRow(new string[] {
                        "Guilherme",
                        "Martins",
                        "guilherme@guilherme.com"});
#line 11
    testRunner.When("Preencher os campos obrigatórios", ((string)(null)), table1, "Quando ");
#line 14
    testRunner.And("Clicar em Criar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
    testRunner.Then("Exibir mensagem: Seu usuário foi criado.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Erro preenchimento campos obrigatorios 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro")]
        public virtual void ErroPreenchimentoCamposObrigatorios2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Erro preenchimento campos obrigatorios 2", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("Usuário não cadastrado acesso a página inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Ultimo nome"});
            table2.AddRow(new string[] {
                        "Guilherme",
                        "Martins"});
#line 19
    testRunner.When("Preencher os campos obrigatórios exceto email", ((string)(null)), table2, "Quando ");
#line 22
    testRunner.And("Clicar em Criar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 23
    testRunner.Then("Exibir a mensagem: 2 errors proibiu que este usuário fosse salvo:.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Erro preenchimento campos obrigatorios 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro")]
        public virtual void ErroPreenchimentoCamposObrigatorios1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Erro preenchimento campos obrigatorios 1", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
    testRunner.Given("Usuário não cadastrado acesso a página inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Ultimo nome",
                        "Email"});
            table3.AddRow(new string[] {
                        "Martins",
                        "guilherme@guilherme.com"});
#line 27
    testRunner.When("Preencher os campos obrigatórios exceto nome", ((string)(null)), table3, "Quando ");
#line 30
    testRunner.And("Clicar em Criar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 31
    testRunner.Then("Exibir a mensagem: 1 error proibiu que este usuário fosse salvo:.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Erro preenchimento campos obrigatorios 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro")]
        public virtual void ErroPreenchimentoCamposObrigatorios3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Erro preenchimento campos obrigatorios 3", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
    testRunner.Given("Usuário não cadastrado acesso a página inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Email"});
            table4.AddRow(new string[] {
                        "Guilherme",
                        "guilherme@guilherme.com"});
#line 35
    testRunner.When("Preencher os campos obrigatórios exceto Ultimo nome", ((string)(null)), table4, "Quando ");
#line 38
    testRunner.And("Clicar em Criar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 39
    testRunner.Then("Exibir a mensagem: 3 errors proibiu que este usuário fosse salvo:.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
