# Sistema de Vendas

## 1. Descrição

O **Sistema de Vendas** é um projeto desenvolvido em **C# com ASP.NET MVC**, com o objetivo de gerenciar vendas, clientes, produtos e vendedores.

Principais funcionalidades:

* **Gerenciamento de Vendedores:** Cadastro, login e associação de vendas a um vendedor específico.
* **Gestão de Clientes:** Registro e atualização de informações de clientes.
* **Controle de Produtos:** Cadastro, edição e exclusão de produtos disponíveis para venda.
* **Registro de Vendas:** Associação de clientes, vendedores e produtos em uma venda.
* **Autenticação e Sessão:** Controle de acesso de vendedores, incluindo armazenamento de sessão.
* **Relatórios Básicos:** Visualização das vendas registradas, com informações detalhadas.

**Status do Projeto:** Em andamento — funcionando, mas com espaço para melhorias e novas funcionalidades.

---

## 2. Objetivo

Este projeto tem como principais objetivos:

* Consolidar conhecimentos em **C# e ASP.NET MVC**;
* Desenvolver um sistema completo que una **backend, frontend e persistência de dados**;
* Simular cenários reais de uma aplicação de vendas;
* Criar uma base sólida para futuras melhorias, como relatórios avançados, dashboards e integração com bancos de dados mais robustos.

### 2.1 Tecnologias e Conceitos Utilizados

1. **C# e ASP.NET MVC**: Estruturação do projeto em camadas (Models, Views e Controllers).
2. **Razor Views**: Renderização de páginas dinâmicas.
3. **Sessions em ASP.NET**: Para controle de autenticação e dados do usuário logado.
4. **Validações de Formulário**: Garantia de integridade nos dados inseridos.
5. **Entity Framework / LINQ**
6. **Microsoft SQL Server**

### 2.2 Estrutura do Banco de Dados

O banco foi modelado manualmente através de scripts SQL.

**Tabelas criadas:**

* **Cliente** (Id, Nome, CPF/CNPJ, Email, Senha)
* **Vendedor** (Id, Nome, Email, Senha)
* **Produto** (Id, Nome, Descrição, Preço, Quantidade em Estoque, Unidade de Medida, Link da Foto)
* **Venda** (Id, Data, Total, Id_Vendedor, Id_Cliente)
* **Itens_Venda** (Id_Venda, Id_Produto, Quantidade, Preço)

### 2.3 Boas Práticas Aplicadas

* Separação de responsabilidades (MVC).
* Criação de **models bem estruturados** para representar entidades.
* **Validações cruzadas** para garantir consistência nos registros de vendas.

---

## 3. Instalação e Execução

Para rodar o projeto localmente:

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/JonathanBarr0s/SistemaDeVendas
   ```

2. **Abra no Visual Studio:**
   É recomendado o uso do **Visual Studio 2022** para compilar e executar o projeto.

3. **Crie o banco de dados no SQL Server:**

   * Execute o script SQL disponível em `/Scripts/Script_Banco` para criar todas as tabelas.

4. **Configure a connectionString:**
   Ajuste no `appsettings.json` para apontar para sua instância do SQL Server.

5. **Execute o projeto:**
   Basta iniciar a aplicação.

---

## 4. Telas e Funcionalidades

> * Tela de login de vendedor;

<p align="center">
  <img src="https://github.com/user-attachments/assets/c0f0016c-4321-4d23-9c47-21b53862e720" alt="Tela de Login" width="600"/>
  <br>
  <em>Tela de Login</em>
</p>



> * Tela de cadastro de clientes;
> * Registro de uma nova venda;
> * Relatório/listagem de vendas.

---

## 5. Próximos Passos / Melhorias Futuras

* Implementar **autenticação por JWT** para transformar em uma API consumível por front-ends.
* Criar um **dashboard com gráficos de vendas**.
* Adicionar exportação de relatórios em **PDF e Excel**.
* Criar testes automatizados.
* Adotar **Docker** para facilitar o deploy em diferentes ambientes.

---

## 6. Contribuição

Contribuições são bem-vindas! Para sugerir melhorias:

1. Faça um fork do repositório;
2. Crie uma branch: `git checkout -b minha-branch`;
3. Faça suas alterações e commit: `git commit -m "Minha melhoria"`;
4. Envie um Pull Request.

---

## Licença

Este projeto não possui licença específica.
