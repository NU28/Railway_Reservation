create database Railway
use Railway

create table reg
(
userid nvarchar(10) primary key,
passwords nvarchar(15) unique,
cpassword nvarchar(15),
sans varchar(20),
fname varchar(15),
mname varchar(10),
lname varchar(15),
gender varchar(10),
ms varchar(15),
dob nvarchar(20),
occ varchar(20),
aadhar numeric(12,0),
email nvarchar(30),
mobile numeric(10,0),
nationality varchar(20),
full_add nvarchar(60),
country varchar(30),
pin numeric(10,0),
states varchar(20),
city varchar(20),
phone numeric(10,0)
)
select * from reg

create table Ticket_booking
(
tno int,
tname varchar(25),
sources varchar(20),
destination varchar(20),
jdate  nvarchar(20),
classe varchar(20),
quota varchar(20),
pnr bigint foreign key(pnr) references payment(pnr) on delete cascade
)
select * from Ticket_booking

create table passenger_detail
(
name varchar(30),
age numeric(3,0),
gender varchar(10),
berth_prefer varchar(20),
nationality varchar(30),
pid int
)
select * from passenger_detail

create table passenger_details
(
sn int,
coachno nvarchar(2),
pnr bigint foreign key(pnr) references payment(pnr) on delete cascade
)
select * from passenger_details

create table payment
(
cname varchar(30),
cno numeric(16,0)not null,
cedate nvarchar(10),
cv int,
wmobile numeric(10),
tf int,
pnr bigint primary key,
tid bigint unique,
dtf nvarchar(30)
)
select * from payment

create table NDtoAC
(
train varchar(20),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoAC
insert into NDtoAC values('A P EXPRESS',22416,'06:25 AM')
insert into NDtoAC values('TAJ EXPRESS',12280,'07:00 AM')
insert into NDtoAC values('TOOFAN EXPRESS',13008,'07:30 AM')
insert into NDtoAC values('HIRAKUND EXPRESS',18508,'08:45 AM')
insert into NDtoAC values('JHELUM EXPRESS',11078,'09:30 AM')

create table NDtoMH
(
train varchar(30),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoMH
insert into NDtoMH values('KOTA SPECIAL',09810,'05:15 AM')
insert into NDtoMH values('SWARN JAYANTI EXPRESS',12804,'05:50 AM')
insert into NDtoMH values('TAJ EXPRESS',12280,'07:00 AM')
insert into NDtoMH values('GOLDEN TEMPLE',12904,'07:20 AM')
insert into NDtoMH values('HIRAKUND EXPRESS',18508,'08:45 AM')
insert into NDtoMH values('JHELUM EXPRESS',11078,'09:30 AM')

create table NDtoMB
(
train varchar(30),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoMB
insert into NDtoMB values('PUNJAB MAIL',12138,'05:15 AM')
insert into NDtoMB values('GOLDEN TEMPLE MAIL',12904,'07:20 AM')
insert into NDtoMB values('AMRITSAR KOCHUVELI EXPRESS',12484,'01:40 PM')
insert into NDtoMB values('BANDRA TERMIUS GARIB RATH',12910,'03:35 PM')
insert into NDtoMB values('PASCHIM EXPRESS',12926,'04:45 PM')

create table NDtoCH
(
train varchar(30),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoCH
insert into NDtoCH values('ANDMAN EXPRESS',16032,'02:15 PM')
insert into NDtoCH values('G T EXPRESS',12616,'06:40 PM')
insert into NDtoCH values('TAMIL NADU EXPRESS',12622,'10:30 PM')
insert into NDtoCH values('PUDUCHERRY EXPRESS',22404,'11:45 PM')

create table NDtoKL
(
train varchar(30),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoKL
insert into NDtoKL values('KALKA MAIL',12312,'05:11 AM')
insert into NDtoKL values('HOWRAH EXPRESS',12324,'07:05 AM')
insert into NDtoKL values('POORVA EXPRESS',12304,'05:35 PM')
insert into NDtoKL values('JALIANWALA B EXPRESS',12380,'07:05 PM')

create table NDtoBH
(
train varchar(30),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoBH
insert into NDtoBH values('NEELACHAL EXPRESS',12876,'06:25 AM')
insert into NDtoBH values('HIRAKUND EXPRESS',18508,'08:10 AM')
insert into NDtoBH values('KALINGAUTKAL EXPRESS',18478,'12:05 PM')
insert into NDtoBH values('PURSHOTTAM EXPRESS',12802,'05:05 PM')

create table NDtoJT
(
train varchar(30),
train_no numeric(5,0),
timing nvarchar(20)
)
select * from NDtoJT
insert into NDtoJT values('SARVODAYA EXPRESS',12473,'04:50 AM')
insert into NDtoJT values('MALWA EXPRESS',12919,'05:20 AM')
insert into NDtoJT values('SHRI SHAKTI EXPRESS',22461,'05:30 PM')
insert into NDtoJT values('JAMMU MAIL',14033,'08:10 PM')
insert into NDtoJT values('UTTAR SAMPARK KRANTI',12445,'08:50 PM')
insert into NDtoJT values('HIMSAGAR EXPRESS',16317,'09:10 PM')