CREATE DATABASE [WinFormsForWAB]

go

USE [WinFormsForWAB]

go

CREATE TABLE [LineInformation]
(
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[PCT] INT NOT NULL,
	[LineName] NVARCHAR(100) UNIQUE NOT NULL,
	[Zone] NVARCHAR(50) NOT NULL,
	[WorkPlace] INT,
	[RealWorkPlace] INT,
	[AreaBefore] DECIMAL
	);
 
DROP TABLE [LineInformation]

INSERT INTO [LineInformation] VALUES
	(1, 'line2', 'dsds', 1, 2, 3.3),
	(22, 'line1', 'dsds', 1, 2, 3.3),
	(232, 'sds', 'dsds', 1, 2, 3.3)

SELECT * FROM [LineInformation]

UPDATE [LineInformation]  SET LineId = Id;

--ALTER TABLE [LineInformation] ADD [LineId] INT

--ALTER TABLE [LineInformation] ADD CONSTRAINT FK_LineInformation_Data FOREIGN KEY (LineId) REFERENCES [Data](LineId);

SELECT * FROM [Data]

CREATE TABLE [Data](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[AreaAfter2019] DECIMAL,
	[AreaAfter2020] DECIMAL,
	[AreaAfter2021] DECIMAL,
	[AreaAfter2022] DECIMAL,
	[LineName] NVARCHAR(100) UNIQUE NOT NULL
)

INSERT INTO [Data] VALUES 
	(1,2,3,4,'line2'),
	(2,1,3,4, 'line1'),
	(3,2,1,3, 'sds')


CREATE VIEW V_ShowInformationForAllLines AS SELECT L.PCT, L.LineName, L.[Zone], L.WorkPlace, L.RealWorkPlace, L.AreaBefore, d.AreaAfter2019, d.AreaAfter2020, d.AreaAfter2021, d.AreaAfter2022 FROM [LineInformation] AS L JOIN
[Data] AS d ON l.LineName = d.LineName

ALTER TABLE [Data] ADD CONSTRAINT FK_Data_LineInformation FOREIGN KEY (LineName) REFERENCES LineInformation(LineName)

DROP TABLE [Data]

ALTER TABLE [Data] ADD CONSTRAINT IDENTITY 

INSERT INTO [Data] VALUES ()

DELETE FROM [LineInformation]
DELETE FROM [Data]

DROP TABLE [Data]

go