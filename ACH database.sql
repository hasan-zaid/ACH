use [C:\USERS\HASAN\DESKTOP\ONEDRIVE - ASIA PACIFIC UNIVERSITY\IOOP PROGRESS\ACH\ACH.MDF]

create table technicians (
tech_id nvarchar(50) primary key,
tech_name nvarchar(100) not null,
tech_phone_number nvarchar(30) not null,
tech_password nvarchar(50) not null);

create table customers (
cus_id nvarchar(50) primary key,
cus_name nvarchar(100) not null,
cus_phone_number nvarchar(30) not null,
cus_password nvarchar(50) not null);

create table admins (
admin_id nvarchar(50) primary key,
admin_name nvarchar(100) not null,
admin_phone_number nvarchar(30) not null,
admin_password nvarchar(50) not null);

create table services (
service_id nvarchar(50) primary key,
service_name nvarchar(200) not null,
normal_fee int not null,
urgent_fee int not null);

create table requested_services (
request_no int identity(1, 1) primary key,
service_id nvarchar(50) foreign key references services(service_id) not null,
cus_id nvarchar(50) foreign key references customers(cus_id) not null,
tech_id nvarchar(50) foreign key references technicians(tech_id) null,
service_description nvarchar(500) null,
collection_date nvarchar(50) null);
