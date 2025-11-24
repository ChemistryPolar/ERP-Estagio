USE [master]
GO
DROP DATABASE IF EXISTS [erpBasico]
GO
CREATE DATABASE [erpBasico]
GO
USE [erpBasico]
GO
CREATE TABLE [dbo].[cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Email] [varchar](255) NULL,
	[Telefone] [varchar](15) NULL,
	[cpf] [char](11) NULL,
	[Endereco] [varchar](255) NOT NULL,
	[DataNasc] [date] NULL,
	 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) 
CREATE TABLE [dbo].[funcionario](
	[IdFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Telefone] [varchar](15) NULL,
	[cpf] [char](11) NULL,
´	[Setor] [varchar](255) NOT NULL,
	[Endereco] [varchar](255) NOT NULL,
	[DataNasc] [date] NULL,
	[Username] [varchar](25) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Role] [varchar](10) NOT NULL,
	 CONSTRAINT [PK_funcionario] PRIMARY KEY CLUSTERED 
(
	[IdFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) 
GO
CREATE TABLE [dbo].[fornecedor](
	[IdFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Telefone] [varchar](15) NULL,
	[cnpj] [char](11) NULL,
	[Endereco] [varchar](255) NOT NULL,
	 CONSTRAINT [PK_fornecedor] PRIMARY KEY CLUSTERED 
)
GO
CREATE TABLE [dbo].[produto](
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Descricao] [varchar](255) NOT NULL,
	[Lote] [varchar](15) NULL,
	[Quantidade] [char](11) NULL,
	[Peso] [varchar](255) NOT NULL,
	 CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED 
)
GO