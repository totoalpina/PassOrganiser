create database password_organiser;
use password_organiser;

create table conturi
(
    id          bigint       not null,
    categorie   varchar(50)  null,
    username    varchar(50)  null,
    password    varchar(50)  null,
    description varchar(255) null,
    Primary key (id);	
    constraint conturi_id_uindex
        unique (id)
);


create table users
(
    id       int(2) auto_increment,
    username varchar(50) null,
    password varchar(50) null,
    Primary key (id);	
    constraint users_id_uindex
        unique (id)
);
