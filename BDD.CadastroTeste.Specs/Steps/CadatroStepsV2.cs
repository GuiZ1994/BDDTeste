using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDD.CadastroTeste.Specs
{
    [Binding]
    public class CadastroSteps
    {
        IWebDriver Browser;
        private string uri = "https://automacaocombatista.herokuapp.com/users/new";

        [BeforeScenario]
        public void Init()
        {
            this.Browser = new FirefoxDriver();
        }
        [AfterScenario]
        public void Close()
        {
            this.Browser.Close();
            this.Browser.Dispose();
        }
        
        [Given(@"Usuário não cadastrado acesso a página inicial")]
        public void DadoUsuarioNaoCadastradoAcessoAPaginaInicial()
        {
            this.Browser.Navigate().GoToUrl(uri);
        }

        [When(@"Preencher os campos obrigatórios")]
        public void QuandoPreencherOsCamposObrigatorios(Table table)
        {
            try
            {
                var user_name = Browser.FindElement(By.Id("user_name"));
                user_name.SendKeys(table.Rows[0][0].ToString());
                var user_lastname = this.Browser.FindElement(By.Id("user_lastname"));
                user_lastname.SendKeys(table.Rows[0][1].ToString());
                var user_email = this.Browser.FindElement(By.Id("user_email"));
                user_email.SendKeys(table.Rows[0][2].ToString());
                Thread.Sleep(1000);
            }
            catch (NoSuchElementException)
            {
                Assert.Fail();
            }

        }
        
        [When(@"Clicar em Criar")]
        public void QuandoClicarEmCriar()
        {
            var btncriar = this.Browser.FindElement(By.Name("commit"));
            Thread.Sleep(1000);
            btncriar.Click();
        }
        
        [When(@"Preencher os campos obrigatórios exceto email")]
        public void QuandoPreencherOsCamposObrigatoriosExcetoEmail(Table table)
        {
            var user_name = Browser.FindElement(By.Id("user_name"));
            user_name.SendKeys(table.Rows[0][0].ToString());
            var user_lastname = this.Browser.FindElement(By.Id("user_lastname"));
            user_lastname.SendKeys(table.Rows[0][1].ToString());
            Thread.Sleep(1000);
        }

        [When(@"Preencher os campos obrigatórios exceto nome")]
        public void QuandoPreencherOsCamposObrigatoriosExcetoNome(Table table)
        {
            var user_lastname = this.Browser.FindElement(By.Id("user_lastname"));
            user_lastname.SendKeys(table.Rows[0][0].ToString());
            var user_email = this.Browser.FindElement(By.Id("user_email"));
            user_email.SendKeys(table.Rows[0][1].ToString());
            Thread.Sleep(1000);
        }

        [When(@"Preencher os campos obrigatórios exceto Ultimo nome")]
        public void QuandoPreencherOsCamposObrigatoriosExcetoUltimoNome(Table table)
        {
            var user_name = this.Browser.FindElement(By.Id("user_name"));
            user_name.SendKeys(table.Rows[0][0].ToString());
            var user_email = this.Browser.FindElement(By.Id("user_email"));
            user_email.SendKeys(table.Rows[0][1].ToString());
            Thread.Sleep(1000);
        }


        [Then(@"Exibir mensagem: Seu usuário foi criado\.")]
        public void EntaoExibirMensagemSeuUsuarioFoiCriado_()
        {
           
            var notice = this.Browser.FindElement(By.Id("notice"));
            Assert.AreEqual("Usuário Criado com sucesso", notice.Text);
        }
        
        [Then(@"Exibir a mensagem: 2 errors proibiu que este usuário fosse salvo:\.")]
        public void EntaoExibirAMensagemTodosOsCamposObrigatoriosDevemSerPreenchidos_()
        {
            
            var ErrorCampo = this.Browser.FindElement(By.XPath("//div[@id='error_explanation']/h2"));
            Assert.AreEqual("2 errors proibiu que este usuário fosse salvo:", ErrorCampo.Text);
        }

        [Then(@"Exibir a mensagem: 3 errors proibiu que este usuário fosse salvo:\.")]
        public void EntaoExibirAMensagemTodosOs3CamposObrigatoriosDevemSerPreenchidos()
        {

            var ErrorCampo = this.Browser.FindElement(By.XPath("//div[@id='error_explanation']/h2"));
            Assert.AreEqual("3 errors proibiu que este usuário fosse salvo:", ErrorCampo.Text);
        }

        [Then(@"Exibir a mensagem: 1 error proibiu que este usuário fosse salvo:\.")]
        public void EntaoExibirAMensagemTodosOs1CamposObrigatoriosDevemSerPreenchidos()
        {

            var ErrorCampo = this.Browser.FindElement(By.XPath("//div[@id='error_explanation']/h2"));
            Assert.AreEqual("1 error proibiu que este usuário fosse salvo:", ErrorCampo.Text);
        }
    }
}
