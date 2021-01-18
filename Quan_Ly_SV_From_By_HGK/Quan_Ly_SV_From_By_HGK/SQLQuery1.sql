create table LopHoc (
	Id int primary key identity,
	Code nvarchar(10)
)
;
Create table MonHoc(
	Id int primary key identity ,
	MaMon nvarchar(10),
	TenMon nvarchar(30)
);
Create table SinhVien (
	RollNumber varchar(15) primary key ,
	HoTen nvarchar(150) not null,
	NamSinh int Not null default (1990),
	DiaChi nvarchar(50),
	QueQuan nvarchar(50),
	IdLophoc int null foreign key references LopHoc (Id)
);
create table Diem (
	RollNumber varchar(15) NOT NULL,
	IdMonHoc int NOT NULL,
	DiemThi int NOT NULL DEFAULT(0) CHECK (DiemThi>=0),
	PRIMARY KEY (RollNumber,IdMonHoc)
)
;
select * from SinhVien
