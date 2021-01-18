create table MOCK_DATA (
	Id int identity primary key,
	MakerCar VARCHAR(50)
);
insert into MOCK_DATA (MakerCar) values ('Ford');
insert into MOCK_DATA (MakerCar) values ('Volkswagen');
insert into MOCK_DATA (MakerCar) values ('Infiniti');
insert into MOCK_DATA (MakerCar) values ('Audi');
insert into MOCK_DATA (MakerCar) values ('Land Rover');
insert into MOCK_DATA (MakerCar) values ('Dodge');
insert into MOCK_DATA (MakerCar) values ('Lamborghini');
insert into MOCK_DATA (MakerCar) values ('Volkswagen');
insert into MOCK_DATA (MakerCar) values ('Dodge');
insert into MOCK_DATA (MakerCar) values ('Suzuki');
insert into MOCK_DATA (MakerCar) values ('Pontiac');
insert into MOCK_DATA (MakerCar) values ('Land Rover');
insert into MOCK_DATA (MakerCar) values ('Honda');
insert into MOCK_DATA (MakerCar) values ('Buick');
insert into MOCK_DATA (MakerCar) values ('Hyundai');
insert into MOCK_DATA (MakerCar) values ('Chevrolet');
insert into MOCK_DATA (MakerCar) values ('Lexus');
insert into MOCK_DATA (MakerCar) values ('Dodge');
insert into MOCK_DATA (MakerCar) values ('Lincoln');
insert into MOCK_DATA (MakerCar) values ('Dodge');
create table Car (
	CarId int identity primary key,
	CarModer VARCHAR(50),
	CarModelYear VARCHAR(50),
	CarVin VARCHAR(50),
	/*Thieu ve sua IDmaker cars*/
	IdMakerCar int foreign key REFERENCES  MOCK_DATA(Id)

);
insert into Car (CarModer, CarModelYear, CarVin) values ('300E', 1993, '1N6AA0CH3EN465575');
insert into Car (CarModer, CarModelYear, CarVin) values ('LeSabre', 2004, 'JA4AS2AW5CU744858');
insert into Car (CarModer, CarModelYear, CarVin) values ('Veracruz', 2010, '1FMNE1BW4AD125259');
insert into Car (CarModer, CarModelYear, CarVin) values ('Frontier', 2008, '3FADP0L34AR166600');
insert into Car (CarModer, CarModelYear, CarVin) values ('E150', 2004, 'WBAVC73508K213881');
insert into Car (CarModer, CarModelYear, CarVin) values ('Civic', 2003, '19UUA66256A684428');
insert into Car (CarModer, CarModelYear, CarVin) values ('H3', 2008, '2C3CDYAGXEH385764');
insert into Car (CarModer, CarModelYear, CarVin) values ('Truck', 1985, 'WP0AB2A98FS404216');
insert into Car (CarModer, CarModelYear, CarVin) values ('Camaro', 2011, '5UXWX9C57D0961104');
insert into Car (CarModer, CarModelYear, CarVin) values ('RX', 2012, '5UXFG83579L991171');
insert into Car (CarModer, CarModelYear, CarVin) values ('LaCrosse', 2006, 'WAUGL68E55A955447');
insert into Car (CarModer, CarModelYear, CarVin) values ('CTS-V', 2012, 'WBABN33443J466746');
insert into Car (CarModer, CarModelYear, CarVin) values ('Legacy', 2002, '3FA6P0SU6FR287106');
insert into Car (CarModer, CarModelYear, CarVin) values ('S60', 2005, 'WBANE53516B126194');
insert into Car (CarModer, CarModelYear, CarVin) values ('Range Rover Sport', 2009, 'WAUYGAFC0CN814594');
insert into Car (CarModer, CarModelYear, CarVin) values ('Accord', 1990, '1G4HF57918U963492');
insert into Car (CarModer, CarModelYear, CarVin) values ('Impreza WRX', 2011, '5J8TB4H54DL100459');
insert into Car (CarModer, CarModelYear, CarVin) values ('LeMans', 1964, '5GADV33L46D361941');
insert into Car (CarModer, CarModelYear, CarVin) values ('Sierra 1500', 2002, 'WVGEG9BP4CD367007');
insert into Car (CarModer, CarModelYear, CarVin) values ('GT', 2005, '5J6TF2H53DL155759');
insert into Car (CarModer, CarModelYear, CarVin) values ('XJ Series', 2003, '1G6AB5SA4E0768415');
insert into Car (CarModer, CarModelYear, CarVin) values ('Tundra', 2000, '5GAKVBED9CJ615082');
insert into Car (CarModer, CarModelYear, CarVin) values ('57', 2005, 'WAUUL78E28A515313');
insert into Car (CarModer, CarModelYear, CarVin) values ('900', 1991, 'SCFFDABM6EG084992');
insert into Car (CarModer, CarModelYear, CarVin) values ('CT', 2011, 'JH4KA96541C247551');
insert into Car (CarModer, CarModelYear, CarVin) values ('Elantra', 2012, 'WAUDT48H45K264535');
insert into Car (CarModer, CarModelYear, CarVin) values ('Thunderbird', 1989, '3GYFK66N56G702534');
insert into Car (CarModer, CarModelYear, CarVin) values ('Monte Carlo', 1996, '5NPDH4AE5CH806290');
insert into Car (CarModer, CarModelYear, CarVin) values ('Continental', 2000, 'WAUDGAFLXCA790519');
insert into Car (CarModer, CarModelYear, CarVin) values ('Grand Voyager', 1992, 'WVGAV7AX6FW695564');
insert into Car (CarModer, CarModelYear, CarVin) values ('Phantom', 2011, 'WAUVT64B54N493627');
insert into Car (CarModer, CarModelYear, CarVin) values ('SLK-Class', 2009, '5UMBT93538L575808');
insert into Car (CarModer, CarModelYear, CarVin) values ('Laser', 1992, '1N6AA0CC7DN334765');
insert into Car (CarModer, CarModelYear, CarVin) values ('MDX', 2011, 'WP0AA2A84CS994873');
insert into Car (CarModer, CarModelYear, CarVin) values ('9-5', 2003, '2T1BPRHE6FC710737');
insert into Car (CarModer, CarModelYear, CarVin) values ('Landaulet', 2010, 'JTDZN3EU6EJ708258');
insert into Car (CarModer, CarModelYear, CarVin) values ('Grand Vitara', 2001, 'JM1BL1K5XB1950913');
insert into Car (CarModer, CarModelYear, CarVin) values ('C-Class', 1996, 'JN8AE2KP1F9727250');
insert into Car (CarModer, CarModelYear, CarVin) values ('Corsica', 1992, 'WAUDT48H65K233822');
insert into Car (CarModer, CarModelYear, CarVin) values ('Pathfinder', 1993, 'WAUYGBFC0CN657123');
insert into Car (CarModer, CarModelYear, CarVin) values ('Sierra 2500', 2011, 'WAUKG94F46N983619');
insert into Car (CarModer, CarModelYear, CarVin) values ('Ascender', 2006, 'WBAKE5C5XCJ656815');
insert into Car (CarModer, CarModelYear, CarVin) values ('Tracer', 1992, '5LMJJ2H57EE821516');
insert into Car (CarModer, CarModelYear, CarVin) values ('C70', 2013, 'WAUBNBFB7AN880887');
insert into Car (CarModer, CarModelYear, CarVin) values ('Caprice Classic', 1996, 'YV4902BZ2D1302806');
insert into Car (CarModer, CarModelYear, CarVin) values ('Silverado', 2001, '1G6DB1ED0B0755331');
insert into Car (CarModer, CarModelYear, CarVin) values ('B-Series Plus', 1996, 'WBA3B3C55FJ115936');
insert into Car (CarModer, CarModelYear, CarVin) values ('Skylark', 1996, '1G6AB5SA2E0472552');
insert into Car (CarModer, CarModelYear, CarVin) values ('Bonneville', 1987, '1FTEX1C89AK012692');
insert into Car (CarModer, CarModelYear, CarVin) values ('Sonata', 1995, 'WAUEF98E08A838833');


select * from MOCK_DATA