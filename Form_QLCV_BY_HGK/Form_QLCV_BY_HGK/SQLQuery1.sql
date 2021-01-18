create table trangthai(
	ID_tt int ,
	Name_tt nvarchar(50)
)
INSERT INTO trangthai (ID_tt, Name_tt)
VALUES ('0', 'Moi Tao');
select * from trangthai
INSERT INTO trangthai (ID_tt, Name_tt)
VALUES ('1', 'Dang thuc hien');
INSERT INTO trangthai (ID_tt, Name_tt)
VALUES ('2', 'Hoan Thanh');

drop table congviec
create table congviec(
	ID_Cv int PRIMARY KEY  identity,
	ngaytao DAtetime not null,
	ID_TT int not null,
	ngayhoanthanh Datetime not null,
	Noidung nvarchar(100) not null
) 
select * from congviec
