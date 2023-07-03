# API Simples em C#/.Net

Este é um projeto simples para criar uma API básica utilizando o framework .NET Core. A API permite gerenciar uma lista de tarefas (tasks) com os campos Id, Title, Description e Completed.

## Pré-requisitos
Certifique-se de ter as seguintes ferramentas instaladas:

- [.NET Core SDK](https://dotnet.microsoft.com/download) - versão X.X.X
- [Node.js](https://nodejs.org/) - versão X.X.X
- [Visual Studio Code](https://code.visualstudio.com/) (opcional) - versão X.X.X

1. Clone este repositório:
```
git clone https://github.com/BeatrizUser/ApiDotNet.git
```
3. Navegue até a pasta do projeto:
```
cd ApiDotNet
```
5. Instale as dependências do projeto:
```
  dotnet restore
```

## Executando o Projeto

1. Inicie o servidor de desenvolvimento:
```
  dotnet run
```
3. Abra o navegador e acesse http://localhost:5000/api/tasks.

## Funcionalidades
  - Listar todas as tarefas: GET /api/tasks
  - Obter uma tarefa por Id: GET /api/tasks/{id}
  - Criar uma nova tarefa: POST /api/tasks
  - Atualizar uma tarefa existente: PUT /api/tasks/{id}
  - Excluir uma tarefa: DELETE /api/tasks/{id}
    
## Capturas de Tela
N/A

## Documentação
N/A

## Contribuição
Contribuições são bem-vindas! Se você tiver sugestões, correções de bugs ou melhorias, fique à vontade para abrir uma issue ou enviar um pull request.

Espero que isso atenda às suas necessidades! Sinta-se à vontade para fazer ajustes adicionais ou adicionar mais informações relevantes ao README. Se você tiver mais dúvidas, estou aqui para ajudar.
