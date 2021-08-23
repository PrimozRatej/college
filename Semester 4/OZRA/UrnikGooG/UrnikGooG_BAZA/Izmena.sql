CREATE TABLE [dbo].[Izmena]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DatumZačetka] DATETIME NOT NULL, 
    [DatumKonca] DATETIME NOT NULL, 
    CONSTRAINT [FK_Opravilo] FOREIGN KEY ([Id]) REFERENCES [Opravilo]([Id])
)
