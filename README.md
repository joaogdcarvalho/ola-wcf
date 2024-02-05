# PROJETO OLÁ WCF

## Descrição do Projeto

O Projeto **OlaWCF** tem como propósito fundamental a criação de um serviço web por meio do framework WCF (Windows Communication Foundation). Este repositório é composto por três partes distintas: `AppCliente`, `Servico`, e `Site`. Cada uma dessas componentes desempenha uma função específica no ecossistema do projeto, contribuindo para a oferta de uma solução integral para interações cliente-servidor.

O foco central deste projeto é estabelecer um serviço web eficiente e funcional utilizando as capacidades do WCF. Os tópicos abordados incluem C#, serviço, assembly, WCF, site, hello-world e console-application. A estrutura organizacional e a clareza nos papéis desempenhados por cada parte do projeto visam facilitar o entendimento e a colaboração efetiva no desenvolvimento e manutenção do sistema.

## Estrutura do Projeto

O projeto é estruturado da seguinte maneira:

```
AppCliente
|-- Properties
|   |-- AssemblyInfo.cs
|-- App.config
|-- Program.cs
|-- ServicoRef.cs
|-- AppCliente.csproj

Servico
|-- Properties
|   |-- AssemblyInfo.cs
|-- IServico.cs
|-- Servico.cs
|-- Servico.csproj

Site
|-- My Project
|   |-- MyExtensions
|   |-- Application.myapp
|   |-- Resources.resx
|   |-- Settings.settings
|   |-- Application.Designer.vb
|   |-- AssemblyInfo.vb
|   |-- Resources.Designer.vb
|   |-- Settings.Designer.vb
|-- packages.config
|-- Web.config
|-- Web.Debug.config
|-- Web.Release.config
|-- Site.vbproj

.gitattributes
.gitignore
README.md
OlaWCF.sln
```

## Histórico de Commits

### Sep 20, 2020
- Atualização do arquivo README.md com um novo título.

### May 28, 2020
- Adição dos arquivos iniciais do projeto. Inclusão de `.gitignore` e `.gitattributes`.
