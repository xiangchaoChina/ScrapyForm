
create database spidercenter

/* table config id */
drop table if exists Spider;
create table Spider
(
Sid int AUTO_INCREMENT primary key,
SpiderName nvarchar(100) not null default '',
SpiderConfigID int not null default -1 ,
CreateTime datetime not null default now(),
IsDel tinyint not null default 1
);


/* table config id */
drop table if exists SpiderConfig;
create table SpiderConfig
(
Cid int auto_increment primary key ,
ConfigName nvarchar(100) not null default '',
SpiderPath nvarchar(512) not null default '',
LogName nvarchar(256) not null default '',
SpiderOutPut nvarchar(256) not null default '',
AutoParms nvarchar(256) not null default ''
)
