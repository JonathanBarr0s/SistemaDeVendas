# SistemaDeVendas


-- Criar tabela Cliente
CREATE TABLE Cliente (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    CPF_CNPJ VARCHAR(14) NOT NULL UNIQUE,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(100) NOT NULL
);

-- Criar tabela Vendedor
CREATE TABLE Vendedor (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(100) NOT NULL
);

-- Criar tabela Produto
CREATE TABLE Produto (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao TEXT,
    Preco_Unitario DECIMAL(9,2) NOT NULL,
    Quantidade_Estoque DECIMAL(9,2) NOT NULL,
    Unidade_Medida CHAR(3),
    Link_Foto VARCHAR(255)
);

-- Criar tabela Venda
CREATE TABLE Venda (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Data DATETIME NOT NULL,
    Total DECIMAL(9,2) NOT NULL,
    Id_Vendedor INT NOT NULL,
    Id_Cliente INT NOT NULL,
    CONSTRAINT FK_Venda_Vendedor FOREIGN KEY (Id_Vendedor) REFERENCES Vendedor(Id),
    CONSTRAINT FK_Venda_Cliente FOREIGN KEY (Id_Cliente) REFERENCES Cliente(Id)
);

-- Criar tabela Itens_Venda
CREATE TABLE Itens_Venda (
    Id_Venda INT NOT NULL,
    Id_Produto INT NOT NULL,
    Quantidade_Produto DECIMAL(9,2) NOT NULL,
    Preco_Produto DECIMAL(9,2) NOT NULL,
    CONSTRAINT PK_Itens_Venda PRIMARY KEY (Id_Venda, Id_Produto),
    CONSTRAINT FK_Itens_Venda_Venda FOREIGN KEY (Id_Venda) REFERENCES Venda(Id),
    CONSTRAINT FK_Itens_Venda_Produto FOREIGN KEY (Id_Produto) REFERENCES Produto(Id)
);