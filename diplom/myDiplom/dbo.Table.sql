CREATE TABLE [dbo].[distribution]
(
	[country] INT NOT NULL, 
    [age] VARCHAR(50) NOT NULL, 
    [education] VARCHAR(50) NOT NULL, 
    [gender] VARCHAR(50) NOT NULL, 
    [wish_migration] INT NOT NULL, 
    [culture_tradition] VARCHAR(50) NOT NULL, 
    [culture_susceptibility] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([country]) 
)
