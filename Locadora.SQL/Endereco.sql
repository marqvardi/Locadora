CREATE TABLE [dbo].[Endereco]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	Logradouro varchar(300),
	Bairro varchar(100),
	cep varchar(8) not null,
	numero varchar(10),
	complemento varchar(1000),
	[id_cliente] int NOT null FOREIGN KEY REFERENCES cliente(id)
)

