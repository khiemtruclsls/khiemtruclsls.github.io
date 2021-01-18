create table Question (
	Id_QT int  Primary key IDENTITY ,
	Cau_Hoi nvarchar(100) not null,
	Diem int not null,
	Nhieu_dap_an bit 
)
create table AnsWer(
	Id_AW int not null primary key identity ,
	Tra_Loi  nvarchar(200) not null ,
	Ket_qua bit ,
	QT_ID int foreign key references Question(Id_QT)
)
create table Result(
 ID int Primary key not null identity ,
 TDBD datetime ,
 TDKT datetime ,
 name nvarchar(50), 
 Diem int 
)
create table ResultAw(
	TestID int foreign key references Result(ID) ,
	Dap_An int foreign key references AnsWer(Id_AW) ,
	primary key(TestID,Dap_An)
)
Create table Test (
	Id int not null primary key identity , 
	Soluong_Ques int ,
	Tong_DIem int ,
	Ten nvarchar(50) 

)
create table QueStionTEst(
	IDTest int foreign key references Test(Id) ,
	Id_Qes int foreign key references Question(Id_QT) ,
	primary key(IDTest,Id_Qes)
)
drop table Question