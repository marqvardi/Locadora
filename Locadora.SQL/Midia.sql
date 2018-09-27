CREATE TABLE [dbo].[Midia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Titulo] VARCHAR(100) NOT NULL, 
    [QuantidadeComprada] INT NOT NULL, 
    [QuantidadeAlugada] INT NULL, 
    [QuantidaDisponivel] as QuantidadeComprada - isnull(QuantidadeAlugada, 0),	
	id_categoria int not null foreign key references Categoria(Id), 
    [tipo_midia] SMALLINT NOT NULL
)
