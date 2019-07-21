#BDDcadastroTeste

Visando a página teste informada simulei 4 cenários para poder seguir com o teste.

Recursos:

Foi utilizada a linguagem de C# para fazer o teste.
Utilizei os seguintes frameworks e extenções: Specflow v2.2.0, Specflow.Tools.Ms.Build.Generation v2.3.0, Specflow.MsTest v2.2.0, Selenium.WebDriver v3.141.0, Selenium.Support v3.141.0, Selenium.WebDriver.FirefoxDriver v3.141.0 e Extensão Specflow for Visual Studio 2019.

Bugs:

O cenário 3, está com falha pois ao cadastrar apenas o NOME e o E-mail, ignorando o Ultimo nome (um campo obrigatório), o cadastro está sendo feito e deixando de informar a mensagem de erro necessária.
