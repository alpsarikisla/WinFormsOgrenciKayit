CREATE DATABASE DersOrnek
GO
USE DersOrnek
GO
CREATE TABLE Sehirler
(
	ID int IDENTITY(1,1),
	Isim nvarchar(50),
	CONSTRAINT pk_sehir PRIMARY KEY(ID)
)
GO
CREATE TABLE Ilceler
(
	ID int IDENTITY(1,1),
	SehirID int,
	Isim nvarchar(500),
	CONSTRAINT pk_ilce PRIMARY KEY(ID),
	CONSTRAINT fk_ilce_Sehir FOREIGN KEY(SehirID) REFERENCES Sehirler(ID)
)
GO
CREATE TABLE yok_universiteler
(
	ID int IDENTITY(1,1),
	Isim nvarchar(500),
	CONSTRAINT pk_Universite PRIMARY KEY(ID),
)
GO
CREATE TABLE yok_fakulteler
(
	ID nvarchar(50),
	UniversiteID int,
	Isim nvarchar(500),
	CONSTRAINT pk_fakulte PRIMARY KEY(ID),
	CONSTRAINT fk_fakulte_universite FOREIGN KEY(UniversiteID) REFERENCES yok_universiteler(ID)
)
GO
CREATE TABLE yok_Bolumler
(
	ID int,
	fakulteID nvarchar(50),
	UniversiteID int,
	Isim nvarchar(500),
	CONSTRAINT pk_bolum PRIMARY KEY(ID),
	CONSTRAINT fk_bolum_fakulte FOREIGN KEY(fakulteID) REFERENCES yok_fakulteler(ID),
	CONSTRAINT fk_bolum_universite FOREIGN KEY(UniversiteID) REFERENCES yok_universiteler(ID)
)
GO
CREATE TABLE Ogrenciler
(
	ID int IDENTITY(1,1),
	SehirID int,
	IlceID int,
	TCNo nvarchar(11) NOT NULL,
	Isim nvarchar(75),
	Soyisim nvarchar(75),
	TelNo nvarchar(11),
	Adres nvarchar(500),
	Resim nvarchar(500),
	CONSTRAINT pk_ogrenci PRIMARY KEY(ID),
	CONSTRAINT fk_ogrenci_sehir FOREIGN KEY(SehirID) REFERENCES Sehirler(ID),
	CONSTRAINT fk_ogrenci_ilce FOREIGN KEY(IlceID) REFERENCES Ilceler(ID)
)
GO
CREATE TABLE OgrenciOkullar
(
	ID int IDENTITY(1,1),
	OgrenciID int,
	UniversiteID int,
	FakulteID nvarchar(50),
	BolumID int,
	BaslangicYil int NOT NULL,
	BitisYil int,
	Durum bit,
	CONSTRAINT pk_ogrenciOkul PRIMARY KEY (ID),
	CONSTRAINT fk_ogrenciokul_ogrenci FOREIGN KEY(OgrenciID) REFERENCES Ogrenciler(ID),
	CONSTRAINT fk_ogrenciokul_universite FOREIGN KEY(UniversiteID) REFERENCES yok_universiteler(ID),
	CONSTRAINT fk_ogrenciokul_fakulte FOREIGN KEY(FakulteID) REFERENCES yok_fakulteler(ID),
	CONSTRAINT fk_ogrenciokul_bolum FOREIGN KEY(BolumID) REFERENCES yok_Bolumler(ID),
)