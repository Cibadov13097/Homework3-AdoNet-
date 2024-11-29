CREATE DATABASE Homework1

drop table workerS
drop table companies
drop table Id_card


CREATE TABLE Companies(
id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30),
Max_Workers_count INT
);



CREATE TABLE Workers(
id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30),
Age INT,
Salary FLOAT,
Company_id INT FOREIGN KEY REFERENCES Companies(id)
);

CREATE TABLE Id_card(
id INT PRIMARY KEY IDENTITY,
id_no VARCHAR(10),
worker_id INT FOREIGN KEY REFERENCES Workers(id),
)


Select * from Workers
Select * from Companies


