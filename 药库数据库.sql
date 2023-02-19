IF DB_ID('MedBase') IS NOT NULL						
	DROP DATABASE MedBase;					
CREATE DATABASE MedBase ;					

USE MedBase;		

--用户表
IF OBJECT_ID('tb_User') IS NOT NULL						
	DROP TABLE tb_User;		
CREATE TABLE tb_User
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Password
		VARBINARY(128)
		NOT NULL);
INSERT tb_User
	(No,Password)
	VALUES
	('3210707051',HASHBYTES('MD5','7051'));

--单据表
IF OBJECT_ID('tb_Bills') IS NOT NULL
   DROP TABLE tb_Bills
CREATE TABLE tb_Bills
(No
   CHAR(10)
   NOT NULL
   PRIMARY KEY
,Type
   VARCHAR(52)
,Sender
  VARCHAR(52)
,REMARK
VARCHAR(132)
,Time
VARCHAR(40)
,Status
VARCHAR(24)
)