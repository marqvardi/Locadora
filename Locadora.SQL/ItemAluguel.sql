CREATE TABLE [dbo].[ItemAluguel]
(
	Id_Aluguel int not null foreign key references aluguel(id),
	Id_Midia int not null foreign key references midia(id),
    [Quantidade] INT NOT NULL, 
    [StatusDevolucao] BIT NOT NULL, 
    [Id_Cliente] INT NULL foreign key references Cliente(id), 
    CONSTRAINT [PK_ItemAluguel] PRIMARY KEY ([Id_Aluguel], [Id_Midia]) 
)
