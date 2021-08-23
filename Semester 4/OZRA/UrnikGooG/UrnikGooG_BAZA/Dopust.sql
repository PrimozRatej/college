CREATE TABLE [dbo].[Dopust]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DatumZačetka] DATETIME NOT NULL, 
    [DatumKonca] DATETIME NOT NULL, 
    [Redni] BIT NOT NULL
)
