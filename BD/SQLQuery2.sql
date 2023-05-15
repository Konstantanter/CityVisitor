CREATE TABLE [dbo].[City]
(
	[Id]     [int]  IDENTITY(1,1) NOT NULL,
    [NameReg] NVARCHAR(MAX) NULL, 
    [NameCity] NVARCHAR(MAX) NULL, 
	[PathData] NVARCHAR(MAX) NULL, 
    [Visited] NVARCHAR(10) NULL
)
