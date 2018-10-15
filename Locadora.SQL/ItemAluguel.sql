CREATE TABLE [dbo].[ItemAluguel]
(
	Id_Aluguel int not null foreign key references aluguel(id),
	Id_Midia int not null foreign key references midia(id),
    [Quantidade] INT NOT NULL, 
    [StatusDevolucao] BIT NOT NULL, 
    CONSTRAINT [PK_ItemAluguel] PRIMARY KEY ([Id_Aluguel], [Id_Midia]), 
)
