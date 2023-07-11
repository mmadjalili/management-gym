CREATE TABLE equipment
( 
Eid int not null identity(1,1) primary key,
equipname varchar(250) not null,
edescription varchar(450) not null,
mused varchar(250) not null,
ddate varchar(150) not null,
cost bigint not null
);
