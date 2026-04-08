# AteliApp

Sistema Web para gerenciamento de ateliê de costura, desenvolvido em **C# com ASP.NET Core**, seguindo os princípios de **Clean Architecture**.

Este projeto foi pensado para ser:

- Fácil de evoluir  
- Fácil de manter  
- Organizado desde o início  
- Um bom projeto de estudo e portfólio  

---

## Objetivo do Projeto

O **AteliApp** tem como objetivo auxiliar costureiras(os) no dia a dia do ateliê, permitindo:

- Cadastro de clientes  
- Armazenamento de medidas  
- Controle de encomendas  

Evoluções futuras planejadas:

- Agenda  
- Precificação  
- Relatórios  
- Integração com aplicativo mobile  

---

## Arquitetura Utilizada

O projeto utiliza **Clean Architecture (versão simplificada)**.

### Princípios aplicados

- Separação de responsabilidades  
- Baixo acoplamento  
- Camadas bem definidas  
- Dependências sempre apontando para o núcleo  

---

## Estrutura da Solution

```text
AteliApp.sln
│
├── AteliApp (Web API)
│   ├── Controllers
│   ├── Program.cs
│   └── appsettings.json
│
├── AteliApp.Application (Class Library)
│   ├── Services
│   ├── UseCases
│   └── DTOs
│
├── AteliApp.Domain (Class Library)
│   ├── Entities
│   └── Interfaces
│
└── AteliApp.Infrastructure (Class Library)
    ├── Persistence
    ├── Repositories
    └── Migrations
