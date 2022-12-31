CREATE DATABASE utssashiiks;
USE DATABASE utssashiiks;

CREATE table karyawan(
	nopeg int (10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nama varchar (25) NOT NULL,
	alamat varchar (25) NOT NULL
);

ALTER TABLE karyawan
ADD COLUMN jenis_kelamin CHAR(2) NOT NULL,
ADD COLUMN id_departement INT(8) NOT NULL,
ADD COLUMN departement Varchar (15) NOT NULL,
ADD COLUMN kode_pos CHAR (5) NOT NULL,
ADD COLUMN tanggal_lahir DATE NOT NULL,
ADD COLUMN salary INT (10) NOT NULL


insert into karyawan (nama, alamat, jenis_kelamin, id_departement, departement, kode_pos, tanggal_lahir, salary)
VALUES 
	("sashi kirana", "BOGOR", "P", 1, "kominfo", "1111", "2003-05-21", 200000),
	("Nadya Zahra", "BOGOR", "P", 2, "Litbank", "1212", "2002-10-17", 100000),
	("Abizard", "TANGERANG", "L", 3, "Litbank", "1313", "2003-05-2", 300000),
	("Arfiano Jordhy", "BOGOR", "L", 4, "kominfo", "1414", "2002-10-28", 400000),
	("Kevin Fadhillah", "JAKUT", "L", 5, "kominfo", "1515", "2003-05-15", 500000),
	("Alifia Aurelia", "TANGERANG", "P", "P", 6, "Litbank", "1616", "2002-07-26", 600000),
;

SELECT nama, jenis_kelamin FROM karyawan;

SELECT nama, jenis_kelamin FROM karyawan WHERE jenis_kelamin='P';

SELECT nama, id_departement, salary FROM karyawan;

ALTER TABLE karyawan
ADD COLUMN id-divisi INT(10)

ALTER TABLE karyawan
RENAME TO pegawai;