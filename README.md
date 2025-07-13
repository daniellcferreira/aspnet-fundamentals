# ASP.NET & .NET Projects Collection

![.NET](https://img.shields.io/badge/.NET-Backend-512BD4?style=flat-square&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-Language-239120?style=flat-square&logo=csharp)
![Blazor](https://img.shields.io/badge/Blazor-Web%20UI-512BD4?style=flat-square&logo=blazor)
![WebAPI](https://img.shields.io/badge/Web%20API-RESTful-007ACC?style=flat-square&logo=visualstudiocode)

## Descrição

Este repositório contém uma coleção de projetos desenvolvidos com o framework .NET 8, utilizando diferentes modelos de aplicações oferecidos pela plataforma. Os projetos foram criados com o objetivo de praticar e demonstrar os principais recursos do desenvolvimento back-end e front-end com C# e ASP.NET Core, cobrindo desde aplicações simples de console até arquiteturas web modernas com Blazor e APIs RESTful.

Cada pasta de projeto representa um cenário diferente de uso do .NET, ideal para fins educacionais, testes de conceito ou como base para novos projetos reais. Os exemplos abordam estruturação de middleware, controle de rotas, criação de componentes, uso de Razor Pages, princípios de Programação Orientada a Objetos (POO), e muito mais.

Além disso, os projetos foram configurados com boas práticas como `.gitignore`, organização em camadas (onde aplicável), mensagens de commit padronizadas e uso da CLI do .NET para geração dos templates. Tudo isso com foco na clareza, manutenibilidade e aprendizado contínuo.

---

## Projetos Incluídos

### 1. **ASP.NET Core Empty**
- Projeto básico com pipeline manual (uso de `app.UseMiddleware`).
- Inclui middleware personalizado `AuthMiddleware`.

### 2. **ASP.NET Core MVC**
- Estrutura tradicional com Controllers e Views.
- Organização clara de rotas, ações e layout padrão.

### 3. **ASP.NET Core Razor Pages**
- Modelo focado em páginas com C# e Razor integrados.
- Ideal para aplicações mais simples ou de pequeno porte.

### 4. **Blazor Server**
- Aplicação interativa executada no servidor com SignalR.
- Criada com o comando: `dotnet new blazor -n BlazorServer`

### 5. **Blazor WebAssembly**
- Aplicação executada 100% no navegador.
- Criada com: `dotnet new blazorwasm -n BlazorWasmApp`

### 6. **ASP.NET Core Web API**
- API RESTful com suporte a Swagger por padrão.
- Endpoint `WeatherForecast` gerado automaticamente.

### 7. **Console App**
- Projeto base de linha de comando para testes e lógica geral.
- Inclui exemplos com `Carro` e princípios de POO.

### 8. **Projeto POO com C#**
- Uso de classes (`Carro`) com atributos estáticos e de instância.
- Explora instanciamento de objetos em `Program.cs`.

