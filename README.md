<div align="right">

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET-MVC-blue)
![EF Core](https://img.shields.io/badge/EF%20Core-9.0-green)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-Database-blue)
![Docker](https://img.shields.io/badge/docker-ready-blue)
![API Status](https://img.shields.io/badge/status-online-success)

</div>

<h1 align="center">Sistema de Vendas</h1>

## Descrição Geral

O projeto **Sistema de Vendas** é uma **aplicação web desenvolvida em ASP.NET Core MVC**, criada para gerenciar **clientes, vendedores, produtos e vendas**, simulando um sistema real de controle comercial.

A aplicação possui **interface web (Views)**, autenticação por sessão, controle de acesso via middleware e funcionalidades completas de **cadastro, listagem, edição, exclusão e relatórios de vendas**.

🐳 **Docker Image: https://hub.docker.com/r/jonathanbarr0s/sistema-de-vendas**

🔗 **Acesse a API: https://sistemadevendas.onrender.com**

###### ⚠️ *Nota: Esta API pode levar até 50 segundos para inicializar na primeira requisição. Isso ocorre porque ela está hospedada no plano gratuito do Render, que hiberna a aplicação quando fica inativa.*

---

<br>

## Sumário

- [Tecnologias Utilizadas](#1-tecnologias-utilizadas)
- [Visão Geral da Arquitetura](#2-visão-geral-da-arquitetura)
- [Funcionalidades do Sistema](#3-funcionalidades-do-sistema)
- [Como Rodar](#4-como-rodar)
- [Acompanhe Meu Trabalho](#5-acompanhe-meu-trabalho)

<br>

## 1. Tecnologias Utilizadas

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- Bootstrap
- PostgreSQL
- FluentValidation
- Docker

<br>

## 2. Visão Geral da Arquitetura

O projeto segue o padrão **MVC (Model-View-Controller)**, separando responsabilidades de forma clara:

- **Models**: Representam as entidades do sistema e o mapeamento com o banco de dados.
- **Controllers**: Responsáveis pelo fluxo da aplicação, regras de negócio e interação com as Views.
- **Views**: Interface web do sistema, permitindo interação do usuário.
- **Services**: Camada responsável por validações e regras específicas de negócio.
- **Middleware**: Controle de autenticação e acesso às rotas protegidas.
- **Data**: Contexto do banco de dados utilizando Entity Framework Core.

<br>

## 3. Funcionalidades do Sistema

### 3.1 Autenticação
- Login de vendedores
- Controle de sessão
- Middleware que protege rotas autenticadas
- Logout

### 3.2 Clientes, Vendedores e Produtos
- Cadastro, edição e exclusão
- Pesquisa por filtro
- Validações customizadas
- Listagem paginada

### 3.3 Vendas
- Registro de vendas com múltiplos produtos
- Associação com cliente e vendedor
- Filtro por período
- Listagem paginada
- Visualização detalhada da venda

<br>

## 4. Como Rodar

A API pode ser executada de diferentes maneiras dependendo do seu ambiente. Abaixo estão as três formas recomendadas:

### 4.1 Render (online, já hospedado)

A maneira mais simples é acessar a API diretamente no ambiente publicado:

🔗 **API rodando no Render:** *https://sistemadevendas.onrender.com*

###### ⚠️ *Nota: Esta API pode levar até 50 segundos para inicializar na primeira requisição. Isso ocorre porque ela está hospedada no plano gratuito do Render, que hiberna a aplicação quando fica inativa.*

### 4.2 Rodar com Docker (localmente)

Para rodar a API dentro de containers Docker, basta seguir os passos:

1. Baixe deste repositório **somente** o arquivo `docker-compose.yml`, que está na branch **docker**.
2. Suba a API e o banco Postgres com Docker Compose executando o comando abaixo no PowerShell, no mesmo diretório do arquivo `docker-compose.yml` que você baixou:

```bash
docker compose up -d
```

O Compose irá:

- Baixar a imagem da API do Docker Hub.
- Criar o container do Postgres.
- Subir os dois containers conectados em uma rede interna.
- Aplicar automaticamente as migrations do banco.

3. Acesse a API pela URL: *[http://localhost:8080/Login](http://localhost:8080/Login)*

###### *Nota: não é necessário ter Visual Studio ou PostgreSQL local instalado.*

### 4.3 Rodar via Visual Studio (modo desenvolvedor)

#### **Pré-requisitos recomendados**

* .NET 8 SDK.
* Visual Studio 2026.
* PostgreSQL.

#### **Passo a passo**

1. Abra a solução `SistemaDeVendas.slnx`.
2. Garanta que a connection string do *appsettings.Development.json* aponte para um banco local.
3. Pressione **F5** para rodar. Na primeira execução, o Entity Framework executará automaticamente todas as migrations, criando todo o banco de dados estruturado.
4. Acesse a API pela URL: *[https://localhost:8443/Login](https://localhost:8443/Login)*

<br>

## 5. Acompanhe Meu Trabalho

Me encontre em outras redes:

- **Docker Hub:** [hub.docker.com/u/jonathanbarr0s](https://hub.docker.com/u/jonathanbarr0s)
- **LinkedIn:** [linkedin.com/in/jonathansbarros/](https://www.linkedin.com/in/jonathansbarros/)