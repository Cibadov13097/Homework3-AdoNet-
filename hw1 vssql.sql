CREATE DATABASE Homework1

drop table workerS
drop table companies
drop table Personal_info
drop table Office_printer
drop table printer_worker


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
	Company_id INT FOREIGN KEY REFERENCES Companies(id),
	);

	CREATE TABLE Personal_info(
	id INT PRIMARY KEY IDENTITY,
	Phone_number VARCHAR(30),
	Email VARCHAR(30),
	workers_id INT FOREIGN KEY REFERENCES Workers(id)
	);



	CREATE TABLE Office_printer(
	id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30),
	Model VARCHAR(30));

	CREATE TABLE printer_worker(
	id INT PRIMARY KEY IDENTITY,
	printer_id INT FOREIGN KEY REFERENCES Office_printer(id),
	worker_id INT FOREIGN KEY REFERENCES Workers(id));

	Select * from Workers
	Select * from Companies
	select * from Personal_info
	select * from Office_printer
	select * from printer_worker


SELECT w.Id, w.Name, w.Age, i.id_no AS Id_Num FROM Workers w JOIN Id_card i ON i.Worker_id = w.id 


SELECT w.Id, w.Name, w.Age, p.Email,p.Phone_number FROM Workers w JOIN Personal_info p ON p.id = w.Personal_info_Id Where w.id=1

SELECT w.name,o.name,o.model FROM Workers w JOIN printer_worker p ON p.worker_id=w.id JOIN office_printer o ON o.id=p.printer_id