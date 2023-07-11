CREATE TABLE newmember
(
	
Mid int not null identity(1,1) primary key,
fname varchar(150) not null,
lname varchar(150) not null,
gender varchar(20) not null,
dob varchar(100) not null,
mobile bigint not null,
email varchar(150),
joindate varchar(100) not null,
gymtime varchar(120) not null,
maddress varchar(250) not null,
membershiptime varchar(120) not null
);



