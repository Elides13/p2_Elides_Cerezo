CREATE DATABASE Parcial2Ecg;
GO


USE Parcial2Ecg;
GO


USE [master];
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD=N'12345678',
    DEFAULT_DATABASE = Parcial2Ecg,
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON;
GO
USE Parcial2Ecg;
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2];
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2];
GO


CREATE TABLE Serie (
    id INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(250),
    sinopsis VARCHAR(5000),
    director VARCHAR(100),
    episodios INT,
    fechaEstreno DATE,
);
GO

ALTER TABLE Serie ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO

CREATE PROCEDURE paSerieListar 
    @parametro VARCHAR(50)
AS
BEGIN
    SELECT id, titulo, sinopsis, director, episodios, fechaEstreno
    FROM Serie
    WHERE estado <> -1 AND titulo LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END
GO

INSERT INTO Serie (titulo, sinopsis, director, episodios, fechaEstreno)
VALUES
('Barbie: Vida en la Casa de los Sueños', 'Barbie y sus amigos viven divertidas aventuras en una casa de ensueño', 'Conrad Helten', 75, '2012-05-11'),
('Barbie Aventuras en la Casa de los Sueños', 'Barbie y su familia se embarcan en nuevas aventuras desde su Casa de los Sueños', 'Conrad Helten', 52, '2018-05-03'),
('Barbie y los Rockeros', 'Barbie y su banda de rock viajan en el tiempo para hacer un concierto', 'Bernard Deyriès', 2, '1987-09-27'),
('Barbie: Aventura de Princesa', 'Barbie cambia su vida al intercambiarse con una princesa', 'Conrad Helten', 1, '2020-09-01');



SELECT * FROM SERIE