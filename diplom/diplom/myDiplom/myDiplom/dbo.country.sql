CREATE TABLE [dbo].[country]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name_country] NVARCHAR(50) NULL, 
    [lvl_power] FLOAT NULL, 
    [lvl_technology] FLOAT NULL, 
    [lbl_enviroment] FLOAT NULL, 
    [lvl_educ_tech] FLOAT NULL, 
    [lvl_educ_cult] FLOAT NULL
)
