﻿CREATE TABLE IF NOT EXISTS varosok (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nev VARCHAR(1000) UNIQUE NOT NULL,
    lakossag INT NOT NULL
);

CREATE TABLE IF NOT EXISTS latvanyossagok (
	id int PRIMARY KEY AUTO_INCREMENT,
    nev VARCHAR(1000) NOT NULL,
    leiras VARCHAR(1000) NOT NULL,
    ar INT NOT NULL DEFAULT '0',
    varos_id INT NOT NULL,
    FOREIGN KEY (varos_id) REFERENCES
    	varosok(id)
);