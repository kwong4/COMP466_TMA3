IF OBJECT_ID('dbo.Orders', 'U') IS NOT NULL 
  DROP TABLE dbo.Orders; 

IF OBJECT_ID('dbo.PreMade', 'U') IS NOT NULL 
  DROP TABLE dbo.PreMade; 

IF OBJECT_ID('dbo.privatesecurity', 'U') IS NOT NULL 
  DROP TABLE dbo.privatesecurity; 

IF OBJECT_ID('dbo.users', 'U') IS NOT NULL 
  DROP TABLE dbo.users; 

IF OBJECT_ID('dbo.OS', 'U') IS NOT NULL 
  DROP TABLE dbo.OS; 

IF OBJECT_ID('dbo.CPU', 'U') IS NOT NULL 
  DROP TABLE dbo.CPU; 

IF OBJECT_ID('dbo.RAM', 'U') IS NOT NULL 
  DROP TABLE dbo.RAM; 

IF OBJECT_ID('dbo.HardDrive', 'U') IS NOT NULL 
  DROP TABLE dbo.HardDrive; 

IF OBJECT_ID('dbo.Monitor', 'U') IS NOT NULL 
  DROP TABLE dbo.Monitor; 

IF OBJECT_ID('dbo.SoundCard', 'U') IS NOT NULL 
  DROP TABLE dbo.SoundCard; 

IF OBJECT_ID('dbo.Feedback', 'U') IS NOT NULL 
  DROP TABLE dbo.Feedback;

CREATE TABLE users
(
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	PRIMARY KEY (Username),
	UNIQUE (Email)
)

CREATE TABLE privatesecurity
(
	Email VARCHAR(50) NOT NULL,
	SecurityQuestion VARCHAR(50) NOT NULL,
	SecurityAnswer VARCHAR(50) NOT NULL,
	FOREIGN KEY (Email) REFERENCES dbo.users (Email)  
)

CREATE TABLE OS
(
	ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	CONSTRAINT PK_OS PRIMARY KEY NONCLUSTERED (ID)
)

CREATE TABLE CPU
(
	ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	CONSTRAINT PK_CPU PRIMARY KEY NONCLUSTERED (ID)
)

CREATE TABLE RAM
(
	ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	CONSTRAINT PK_RAM PRIMARY KEY NONCLUSTERED (ID)
)

CREATE TABLE HardDrive
(
	ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	CONSTRAINT PK_HardDrive PRIMARY KEY NONCLUSTERED (ID)
)

CREATE TABLE Monitor
(
	ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	CONSTRAINT PK_Monitor PRIMARY KEY NONCLUSTERED (ID)
)

CREATE TABLE SoundCard
(
	ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	CONSTRAINT PK_SoundCard PRIMARY KEY NONCLUSTERED (ID)
)

CREATE TABLE PreMade
(
	Premade_ID int NOT NULL,
	OS_ID int NOT NULL,
	CPU_ID int NOT NULL,
	RAM_ID int NOT NULL,
	HardDrive_ID int NOT NULL,
	Monitor_ID int NOT NULL,
	SoundCard_ID int NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	FOREIGN KEY (OS_ID) REFERENCES dbo.OS (ID),
	FOREIGN KEY (CPU_ID) REFERENCES dbo.CPU (ID),
	FOREIGN KEY (RAM_ID) REFERENCES dbo.RAM (ID),
	FOREIGN KEY (HardDrive_ID) REFERENCES dbo.HardDrive (ID),
	FOREIGN KEY (Monitor_ID) REFERENCES dbo.Monitor (ID),
	FOREIGN KEY (SoundCard_ID) REFERENCES dbo.SoundCard (ID)
)

CREATE TABLE Orders
(
	Order_ID UNIQUEIDENTIFIER NOT NULL,
	InternalComp_ID UNIQUEIDENTIFIER NOT NULL,
	OS_ID int NOT NULL,
	CPU_ID int NOT NULL,
	RAM_ID int NOT NULL,
	HardDrive_ID int NOT NULL,
	Monitor_ID int NOT NULL,
	SoundCard_ID int NOT NULL,
	Cost VARCHAR(20) NOT NULL,
	Username VARCHAR(50) NOT NULL,
	FOREIGN KEY (OS_ID) REFERENCES dbo.OS (ID),
	FOREIGN KEY (CPU_ID) REFERENCES dbo.CPU (ID),
	FOREIGN KEY (RAM_ID) REFERENCES dbo.RAM (ID),
	FOREIGN KEY (HardDrive_ID) REFERENCES dbo.HardDrive (ID),
	FOREIGN KEY (Monitor_ID) REFERENCES dbo.Monitor (ID),
	FOREIGN KEY (SoundCard_ID) REFERENCES dbo.SoundCard (ID),
	PRIMARY KEY (Order_ID, InternalComp_ID)
)

CREATE TABLE Feedback
(
	User_Feedback VARCHAR(300),
	CONSTRAINT [PK_Feedback] PRIMARY KEY ([User_Feedback])
)

INSERT INTO 
dbo.OS 
VALUES 
('0', 'Windows 10 Pro (64 bit)', '219.99'),
('1', 'Windows 7 Professional (64 bit)', '209.99'),
('2', 'Windows 10 Home (64 bit)', '139.99')

INSERT INTO
dbo.CPU
VALUES
('0', 'Core i7-7700K Processor, 4.20GHz w/ 8MB Cache', '499.99'),
('1', 'Core i7-8700K Processor, 3.7GHz w/ 12MB Cache', '489.99'),
('2', 'Core i5-8600K Processor, 3.5GHz w/ 9MB Cache', '334.99'),
('3', 'Core i5-7600K Processor, 3.80GHz w/ 6MB Cache', '259.99'),
('4', 'Ryzen 5 1600 Processor, 3.2GHz w/ 16MB Cache', '229.99')

INSERT INTO
dbo.RAM
VALUES
('0', 'Vengeance LPX 16GB DDR4 2400MHz CL14 Dual Channel Kit (2 x 8GB), Black', '249.99'),
('1', 'XPG Z1 Gaming Series 16GB DDR4-2400 Dual Channel DDR4 Kit, CL16 (2x 8GB)', '219.99'),
('2', 'HyperX Fury Series 16GB PC4-19200 DDR4 Kit (2x 8GB), Black', '219.99'),
('3', 'Vengeance LPX 8GB DDR4 2400MHz CL14 Dual Channel Kit (2 x 4GB), Black', '139.99'),
('4', 'Vengeance LPX 8GB DDR4 2400MHz CL14 DIMM (1 x 8GB), Black', '124.99')

INSERT INTO
dbo.HardDrive
VALUES
('0', '850 EVO Series Solid State Drive, 500GB', '179.99'),
('1', '4TB BarraCuda HDD, SATA III w/ 256MB Cache', '139.99'),
('2', '850 EVO Series Solid State Drive, 250GB', '109.99'),
('3', '1TB BarraCuda HDD, SATA III w/ 64MB Cache', '59.99'),
('4', 'Blue 1TB Desktop Hard Drive, SATA III w/ 64MB Cache', '54.99')

INSERT INTO
dbo.Monitor
VALUES
('0', 'Optix G24C 23.6in FHD Widescreen Curved VA LED LCD w/ AMD FreeSync, 144Hz', '329.99'),
('1', 'GC2870H 28in FHD Widescreen VA LED LCD', '239.99'),
('2', 'GW2470ML 23.8in Widescreen VA LED LCD w/ HDMI, Speakers', '129.99'),
('3', 'VP239H-P 23in Widescreen LED LCD IPS w/ Speakers', '129.99'),
('4', 'GW2270 21.5in Widescreen VA LED LCD', '99.99')

INSERT INTO
dbo.SoundCard
VALUES
('0', 'Sound Blaster Z PCI-E 5.1 Sound Card w/ Beamforming Microphone', '129.99'),
('1', 'Xonar DGX PCI-E 5.1 Gaming Audio Card w/ Headphone Amp', '64.99'),
('2', 'Xonar DG 5.1 Low Profile PCI Sound Card w/ Headphone AMP', '49.99'),
('3', 'Sound Blaster Audigy Fx 5.1 Sound Card, PCIe', '49.99'),
('4', 'USB Stereo Audio Adaptor', '14.99')

INSERT INTO
dbo.PreMade
VALUES
('0', '0', '0', '0', '0', '0', '0', 'High-End Computer', '1529.94'),
('1', '1', '2', '1', '2', '1', '1', 'Mid-Range Computer', '1109.94'),
('2', '2', '3', '4', '4', '4', '4', 'Low-Range Computer', '849.94')