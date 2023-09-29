

# Projeto MVC ASP.NET - Banco

Este é um projeto MVC ASP.NET que simula um sistema bancário onde os usuários podem ser criados com informações como titular, email e número de conta, com o número de conta gerado automaticamente pelo sistema.

## Pré-requisitos

- Visual Studio (ou outra IDE de sua escolha) instalado.
- Conhecimento básico de ASP.NET MVC e C#.

## Configuração do Projeto

1. Clone ou faça o download deste repositório.

2. Abra o projeto no Visual Studio.

3. Certifique-se de que todas as dependências necessárias estão instaladas. Você pode usar o NuGet Package Manager para instalar as dependências ausentes.

## Como Usar

1. Execute o projeto no Visual Studio.

2. Abra um navegador da web e acesse `http://localhost:porta` (onde `porta` é a porta em que o projeto está sendo executado).

3. Você será direcionado para a página inicial do aplicativo.

4. Navegue até a página de criação de usuários.

5. Preencha o formulário com as informações necessárias, como titular e email.

6. O número de conta será gerado automaticamente e atribuído ao usuário.

7. Clique em "Criar Usuário" para salvar o usuário no banco de dados.

8. Você também pode listar e gerenciar os usuários existentes no aplicativo.

## Estrutura do Projeto

- `Controllers/`: Controladores MVC que gerenciam as ações da aplicação.
- `Models/`: Modelos que representam os objetos de domínio do aplicativo, como o modelo de usuário.
- `Views/`: As views do aplicativo, incluindo as páginas de criação e listagem de usuários.
- `Data/`: Camada de acesso a dados, incluindo entidades de banco de dados e um contexto de banco de dados.
- `Services/`: Lógica de negócios e serviços relacionados a usuários e geração de números de conta.

## Contribuições

  `Edipson Mangue` => https://github.com/eddymangue
 

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas (issues) ou enviar pull requests para melhorar este projeto.


