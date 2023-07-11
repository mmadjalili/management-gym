CREATE TABLE newstaff
( 
Sid int not null identity(1,1) primary key,
fname varchar(150) not null,
lname varchar(150) not null,
gender varchar(20) not null,
dob varchar(100) not null,
mobile bigint not null,
email varchar(150),
joindate varchar(100) not null,
statee varchar(100) not null,
city varchar(100) not null
);
