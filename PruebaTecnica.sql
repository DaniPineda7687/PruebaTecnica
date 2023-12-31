USE [PruebaTecnica]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/07/2023 2:15:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[FechaNacimiento] [date] NULL,
	[Sexo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spUsuarios_CRUD]    Script Date: 22/07/2023 2:15:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUsuarios_CRUD]
	@Id INT = NULL,
	@Nombre NVARCHAR(100) = NULL,
	@FechaNacimiento DATE = NULL,
	@Sexo CHAR(1) = NULL,
	@Action NVARCHAR(10) = NULL
AS
BEGIN
	IF @Action = 'Insert'
	BEGIN
		INSERT INTO Usuarios (Nombre, FechaNacimiento, Sexo) VALUES (@Nombre, @FechaNacimiento, @Sexo);
	END
	ELSE IF @Action = 'Update'
	BEGIN
		UPDATE Usuarios SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Sexo = @Sexo WHERE Id = @Id;
	END
	ELSE IF @Action = 'Delete'
	BEGIN
		DELETE FROM Usuarios WHERE Id = @Id;
	END
	ELSE IF @Action = 'Select'
	BEGIN
		SELECT * FROM Usuarios;
	END
END
GO
