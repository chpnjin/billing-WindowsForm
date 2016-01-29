--總帳資料表
CREATE TABLE GL(
Tx_no nvarchar(50),
Tx_date nvarchar(50),
lot nvarchar(50),
sub_name nvarchar(50),
DC nvarchar(50),
money decimal(18,0),
remark nvarchar(50),
PRIMARY KEY(Tx_no)
);

--科目資料表
CREATE TABLE Subjects(
sub_no nvarchar(50),
sub_name nvarchar(50),
sub_type nvarchar(50),
remark nvarchar(50),
avl nchar(10),
PRIMARY KEY(sub_no)
);

--使用者資料表
CREATE TABLE users(
id nvarchar(50),
password nchar(10),
name nvarchar(50),
avl nchar(10),
PRIMARY KEY(id)
)