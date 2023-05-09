use rms

Alter table roles
(
r_id tinyint not null identity primary key,
r_name varchar(30) not null
)

Create table users
(
u_id int not null primary key identity ,
u_name varchar(30) not null,
u_uname varchar(30)not null unique,
u_password varchar (30) not null,
u_phone varchar(15) not null,
u_address varchar(100) not null,
u_roleID tinyint not null foreign key references roles(r_id) on delete no action on update no action
)
