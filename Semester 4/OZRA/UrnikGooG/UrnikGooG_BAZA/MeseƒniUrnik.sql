CREATE TABLE [dbo].[MesečniUrnik]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Leto] INT NULL, 
    [Mesec] INT NULL, 
    CONSTRAINT [FK_Zaposleni] FOREIGN KEY ([Id]) REFERENCES [Zaposleni]([Id]), 
    CONSTRAINT [FK_Dopust] FOREIGN KEY ([Id]) REFERENCES [Dopust]([Id]), 
    CONSTRAINT [FK_Bolniška] FOREIGN KEY ([Id]) REFERENCES [Bolniška]([Id]), 
    CONSTRAINT [FK_Izmena] FOREIGN KEY ([Id]) REFERENCES [Izmena]([Id])
)
