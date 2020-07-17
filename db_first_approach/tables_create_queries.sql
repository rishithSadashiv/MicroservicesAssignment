create table Project(
	Pid int primary key,
	Pname varchar(50)
);
Create table Employee(
	Eid int primary key,
	Ename varchar(50) not null,
	JoinDate date not null,
	fk_Pid int foreign key references Project(Pid)
);