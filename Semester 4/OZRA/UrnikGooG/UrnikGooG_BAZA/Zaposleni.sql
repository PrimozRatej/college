CREATE TABLE [dbo].[Zaposleni]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Ime] TEXT NOT NULL, 
    [Priimek] TEXT NOT NULL, 
    [Emšo] TEXT NOT NULL, 
    [DavčnaŠtevilka] INT NOT NULL, 
    [UrnaPostavka] FLOAT NOT NULL
)
