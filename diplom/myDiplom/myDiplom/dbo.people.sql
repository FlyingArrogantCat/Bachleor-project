CREATE TABLE [dbo].[people]
(
	[lvl_educ] NVARCHAR(50) NULL, 
    [age] INT NULL, 
    [culture] NVARCHAR(50) NULL, 
    [cult_susceptibility] NVARCHAR(50) NULL, 
    [id_country] INT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([id_country]) 
)
