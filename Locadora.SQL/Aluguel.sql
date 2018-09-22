CREATE TABLE [dbo].[Aluguel]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Id_cliente] INT NOT NULL, 
    [DataHora] DATETIME NOT NULL, 
    [ValorSubTotal] MONEY NOT NULL, 
    [ValorDesconto] MONEY NOT NULL, 
    [ValorTotal] as ValorSubtotal - ValorDesconto, 
    [ValorMulta] MONEY NOT NULL, 
    [Pago] BIT NOT NULL,
	DataEntrega datetime null,
	DataPrevisaoEntrega datetime not null,
	[Status] as case when (DataEntrega is null and DataPrevisaoEntrega > GETDATE()) then 'Atrasado'
					 when (DataEntrega > DataPrevisaoEntrega) then 'Entregue (com atraso)'
					 when DataEntrega is not null and DataEntrega <= DataPrevisaoEntrega then 'Entregue'
					 else 'Emprestado'
					 end

)
