CREATE DATABASE WebApiExample
GO

USE WebApiExample
GO

create table tbSectors
(
	IdSector int identity(1,1),
	NameSector varchar(100)
)
GO

create table tbEmployees
(
	IdEmployee int identity(1,1),
	NameFull varchar(50),
	ContactNumber varchar(9),
	Email  varchar(150),
	thumbnail varchar(100),
	IdSector int 
)
GO

ALTER TABLE tbSectors  WITH CHECK ADD PRIMARY KEY(IdSector)
GO

ALTER TABLE tbEmployees  WITH CHECK ADD PRIMARY KEY(IdEmployee)
GO

ALTER TABLE tbEmployees  WITH CHECK ADD FOREIGN KEY(IdSector)
REFERENCES tbSectors (IdSector)
GO

INSERT INTO tbSectors(NameSector) VALUES('Receptionist')
INSERT INTO tbSectors(NameSector) VALUES('Human resources')
INSERT INTO tbSectors(NameSector) VALUES('Manager')
INSERT INTO tbSectors(NameSector) VALUES('Security')
INSERT INTO tbSectors(NameSector) VALUES('Project leader')
INSERT INTO tbSectors(NameSector) VALUES('Cleaner')
INSERT INTO tbSectors(NameSector) VALUES('Developer')
INSERT INTO tbSectors(NameSector) VALUES('Designer')
INSERT INTO tbSectors(NameSector) VALUES('Illustrator')
INSERT INTO tbSectors(NameSector) VALUES('DataBase admin')

INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Piotr Romero', '1111-1111', 'piotrromero@myCompany.com', 'employee1.svg', 1)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Allana Brandt', '2222-1111', 'allanabrandt@myCompany.com', 'employee2.svg', 2)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Alison Coleman', '3333-1111', 'alisoncoleman@myCompany.com', 'employee3.svg', 2)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Theo Cuevas', '4444-1111', 'theocuevas@myCompany.com', 'employee4.svg', 3)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Amy Louise Brock', '5555-1111', 'amylouiseBrock@myCompany.com', 'employee5.svg', 4)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Jean Matthams', '2222-2222', 'jeanmatthams@myCompany.com', 'employee1.svg', 5)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Addie Jenkins', '3333-3333', 'addiejenkin@myCompany.com', 'employee2.svg', 5)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Brittany Hartley', '4444-4444', 'brittanyhartley@myCompany.com', 'employee3.svg', 6)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Katherine Murray', '5555-5555', 'katherinemurray@myCompany.com', 'employee4.svg', 6)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Maysa Merritt', '1111-5555', 'maysamerritt@myCompany.com', 'employee5.svg', 7)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Matylda Lynn', '1111-4444', 'matyldalynn@myCompany.com', 'employee1.svg', 8)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Kalem Singleton', '1111-3333', 'kalemsingleton@myCompany.com', 'employee2.svg', 9)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Ismael Brock', '1111-2222', 'ismaelbrock@myCompany.com', 'employee3.svg', 10)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Dawood Martin', '2222-3333', 'dawoodmartin@myCompany.com', 'employee4.svg', 7)
INSERT INTO tbEmployees(NameFull, ContactNumber, Email, thumbnail, IdSector ) VALUES('Kuba Cooley', '4444-5555', 'kubacooley@myCompany.com', 'employee5.svg', 7)
