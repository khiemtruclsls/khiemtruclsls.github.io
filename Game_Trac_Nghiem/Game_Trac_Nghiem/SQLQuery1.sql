drop table Ques_tion
drop table Ans_Wer
drop table Result

create table Ques_tion (
	Id int  Primary key IDENTITY ,
	question nvarchar(100) not null, 
	scores int not null,
	Many_answers bit 
)
create table Ans_Wer(
	Id int not null primary key identity ,
	answer  nvarchar(200) not null ,
	Result bit ,
	Id_qt int foreign key references Ques_tion(Id)
)
create table Result(
 Id int Primary key not null identity ,
 Time_to_start datetime ,
 End_time datetime ,
 Name_ nvarchar(50), 
 scores int 
)
create table ResultAw(
	TestID int foreign key references Result(Id) ,
	Dap_An int foreign key references Ans_Wer(Id) ,
	primary key(TestID,Dap_An)
)
Create table Test (
	Id int not null primary key identity , 
	Soluong_Ques int ,
	Tong_DIem int ,
	Name_ nvarchar(50) 

)
create table QueStionTEst(
	IDTest int foreign key references Test(Id) ,
	Id_Qes int foreign key references Ques_tion(Id) ,
	primary key(IDTest,Id_Qes)
)
