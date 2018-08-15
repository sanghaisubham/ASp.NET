create table deptt(deptid int primary key,
name varchar(20),strength int)

create table emp(code int primary key,
name varchar(20),salary money,
deptid int foreign key references deptt(deptid))

insert into deptt values
(1,'sales',20),
(2,'marketing',29),
(3,'finance',40),
(4,'transport',25)

alter table emp add constraint fk1 foreign key(deptid)
references deptt(deptid)