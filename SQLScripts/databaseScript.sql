CREATE DATABASE password_organiser;

CREATE TABLE conturi (
  id bigint(20) NOT NULL,
  categorie varchar(50) DEFAULT NULL,
  username varchar(50) DEFAULT NULL,
  password varchar(50) DEFAULT NULL,
  description varchar(255) DEFAULT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY conturi_id_uindex (id)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE users (
  id int(2) NOT NULL AUTO_INCREMENT,
  username varchar(50) DEFAULT NULL,
  password varchar(50) DEFAULT NULL,
  PRIMARY KEY (id),
  UNIQUE KEY users_id_uindex (id)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

