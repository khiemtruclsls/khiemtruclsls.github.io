Create table LopHoc(
	Id int primary key identity,
	LopHoc nvarchar(150) not null,
	NamBatDau int check ( NamBatDau > 1900 AND NamBatDau < 2100 )
)
Create table HocVien (
	Id int primary key identity,
	HoTen nvarchar(150) ,
	NgaySinh date Not Null,
	Email varchar(250) not null,
	SoDT varchar(20) not null,
	IdLopHoc int not null Foreign key references LopHoc(Id)
)
create table  MonHoc(
	Id int Primary key identity,
	TenMonHoc nvarchar(150),
	VietTat varchar(10)
)
Create table DiemThi(
	IdHocVien int not null,
	IdMonHoc int Not null,
	LanThi int not null Check(LanThi > 1 and LanThi < 10),
	DiemThi int not null check(DiemThi > 1 and DiemThi < 100),
	Primary key(IdHocVien,IdMonHoc,LanThi),
	Foreign key(IdHocVien)references HocVien(Id),
	Foreign key(IdMonHoc)references MonHoc(Id)

)