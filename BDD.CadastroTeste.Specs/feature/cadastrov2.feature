#language: pt-br

Funcionalidade: Cadastro
    Novo usuário 
    Irá se cadastrar para utilizar as funcionalidades
    Assim posso buscar outroas pessoas e ser encontrado 

	
Cenário: Usuario cadastrado com sucesso
    Dado Usuário não cadastrado acesso a página inicial
    Quando Preencher os campos obrigatórios
    | Nome | Ultimo nome | Email |
    | Guilherme | Martins | guilherme@guilherme.com |
    E Clicar em Criar
    Então Exibir mensagem: Seu usuário foi criado.
	
Cenário: Erro preenchimento campos obrigatorios 2
    Dado Usuário não cadastrado acesso a página inicial
    Quando Preencher os campos obrigatórios exceto email
    | Nome | Ultimo nome |
    | Guilherme | Martins |
    E Clicar em Criar
    Então Exibir a mensagem: 2 errors proibiu que este usuário fosse salvo:.

Cenário: Erro preenchimento campos obrigatorios 1
    Dado Usuário não cadastrado acesso a página inicial
    Quando Preencher os campos obrigatórios exceto nome
    | Ultimo nome | Email |
    | Martins | guilherme@guilherme.com |
    E Clicar em Criar
    Então Exibir a mensagem: 1 error proibiu que este usuário fosse salvo:.

Cenário: Erro preenchimento campos obrigatorios 3
    Dado Usuário não cadastrado acesso a página inicial
    Quando Preencher os campos obrigatórios exceto Ultimo nome
    | Nome | Email |
    | Guilherme | guilherme@guilherme.com |
    E Clicar em Criar
    Então Exibir a mensagem: 3 errors proibiu que este usuário fosse salvo:.
