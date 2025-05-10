# 🧮 Atividade Prática Supervisionada (APS): Calculadora de Emergia

## 🍃 Objetivo, Proposta e Funcionalidades

### O objetivo do software

Este projeto tem como objetivo aplicar os conhecimentos adquiridos no curso de Sistemas de Informação, especialmente na disciplina de Modelagem de Sistemas Orientados a Objetos (MSOO), por meio do desenvolvimento de um sistema que implemente o conceito de `emergia`, utilizando o artigo do software SCALE como referência teórica.

### A proposta que foi desenvolvida

A proposta consiste no desenvolvimento de um software capaz de `estimar a emergia associada à produção de componentes eletrônicos`, por meio de cálculos simplificados fundamentados no artigo do software SCALE.

## 📊 Status

`Em desenvolvimento`

### As funcionalidades

- Simulação de cálculo de emergia 
- Relatório automatizado com gráfico
- Interface com o conceito e explicação sobre emergia
- Interface de interação

## 💻 Tecnologias e Pré requisitos

### Tecnologias necessarias


![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white) 

### Pré requisitos a serem cumpridos

- Criação do `banco de dados` e das `tabelas` disponíveis em [Banco de dados + Tabela](https://github.com/JhonaattanDevBr/APS_3_Semestre_Emergia_Componentes_Eletronicos/blob/main/Banco%20de%20dados/Tabelas%20%2B%20Banco.sql)


- Popular a tabela de `Componentes` disponível em [Insert + Tabela Componentes](https://github.com/JhonaattanDevBr/APS_3_Semestre_Emergia_Componentes_Eletronicos/blob/main/Banco%20de%20dados/Insert%20%2B%20Tabela%20Componentes.sql)

- Popular a tabela de `Matérias Primas` diponível em [Insert + Materia Primas](https://github.com/JhonaattanDevBr/APS_3_Semestre_Emergia_Componentes_Eletronicos/blob/main/Banco%20de%20dados/Insert%20%2B%20Tabela%20Materias%20Primas.sql)

- Popular a tabela de `Processos` disponível em [Insert + Tabela Processos](https://github.com/JhonaattanDevBr/APS_3_Semestre_Emergia_Componentes_Eletronicos/blob/main/Banco%20de%20dados/Insert%20%2B%20Tabela%20Processos.sql)

- Popular a tabela de `Produtos` disponível em [Insert + Tabela Produtos](https://github.com/JhonaattanDevBr/APS_3_Semestre_Emergia_Componentes_Eletronicos/blob/main/Banco%20de%20dados/Insert%20%2B%20Tabela%20Produtos.sql)

## 🔍 Como Utilizar

Para utilizar o sistema, o usuário deve navegar pelas opções disponíveis, informando os dados necessários para a realização do cálculo. O objetivo é obter o valor total de emergia envolvida na produção de um componente eletrônico, seguindo o fluxo estabelecido pelas etapas definidas.

1. Informar o nome do componente a ser calculado
2. Informar a quantidade de caminhos, os caminhos representam os elementos 3.principais no desenvolvimento do componente
3. Selecionar uma categoria
4. Selecionar um elemento ou proceso
5. Indicar o esforço utilizado para o elemento ou processo
6. Clicar em Adicionar Elemento para prosseguir
7. Clicar em Remover Último Elemento caso queira retirar
8. Clicar em Calcular
