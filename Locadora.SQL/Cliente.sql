CREATE TABLE [dbo].[Cliente]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	Nome varchar(100) not null,
	DataNascimento Datetime not null,
	[Ativo] Bit not null default (1),

)


