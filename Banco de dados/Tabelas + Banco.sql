-- CREATE DATABASE Lci_Teste;

USE Lci_Teste;

-- Criação da tabela Materias_Primas
CREATE TABLE Materias_Primas (
    id_materiaP INT IDENTITY(100,1) PRIMARY KEY,
    nome_materiaP VARCHAR(100),
    energia_embutida_sej_kg FLOAT
)

-- Criação da tabela Processos
CREATE TABLE Processos (
    id_processo INT IDENTITY(300,1) PRIMARY KEY,
    nome_processo VARCHAR(100),
    energia_sej_por_kg FLOAT,
    descricao TEXT
)

-- Criação da tabela Componentes
CREATE TABLE Componentes (
    id_componente INT IDENTITY(500,1) PRIMARY KEY,
    nome_componente VARCHAR(100),
    massa_gramas FLOAT
)

-- Criação da tabela Produtos
CREATE TABLE Produtos (
    id_produto INT IDENTITY(700,1) PRIMARY KEY,
    nome_produto VARCHAR(100),
    massa_total_gramas FLOAT
);
