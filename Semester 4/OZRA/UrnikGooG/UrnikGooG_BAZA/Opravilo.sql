CREATE TABLE [dbo].[Opravilo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ZačetekOpravila] DATETIME NOT NULL, 
    [KonecOpravila] DATETIME NOT NULL, 
    [Opravljeno] BIT NOT NULL, 
    [Opis] TEXT NULL, 
    CONSTRAINT [FK_TipOpravila] FOREIGN KEY ([Id]) REFERENCES [TipOpravila]([Id])
)
