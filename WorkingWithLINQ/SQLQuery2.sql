create table deptt(deptid int primary key,name varchar(20) ,strength int)

create table emp(code int primary key,
name varchar(20),salary money,
deptid int foreign key references deptt(deptid))

insert into deptt values
(1,'sales',20),
(2,'marketing',20),
(3,'finance',40),
(4,'transport',25)

select * from deptt

insert into emp values
(1,'Subham',80000,3),
(2,'Pranjal',70000,1),
(3,'Prgya',85000,2),
(4,'Gargi',75000,1)

select * from emp