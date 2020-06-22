SELECT * FROM Assignment;
SELECT Name FROM Assignment WHERE Current_Job IS NULL OR Current_Job = ' ';
SELECT Name, Current_Job FROM Assignment;

UPDATE Assignment
SET Current_Job = 'Blah', Shifts = '300'
WHERE (Current_Job IS NULL OR Current_Job = ' ' AND Name = 'John Knight');


SELECT Bakery, Tills, Stocking_shelves, Customer_Services, Meat, Internet_shopping FROM Jobs JOIN Assignment ON [Jobs].Id = Assignment.Id;
SELECT Bakery FROM Jobs WHERE Bakery = 0
SELECT Id FROM Jobs WHERE Bakery = 1 AND Meat = 1;
SELECT Id FROM Jobs WHERE 1 = 1;
SELECT Name FROM Assignment WHERE Id = 1579;
SELECT Id FROM Jobs WHERE Stocking_shelves = 1;
SELECT Assignment.Name FROM Assignment WHERE Assignment.Id = 1579;
SELECT DISTINCT Name, Assignment.Id FROM Assignment, Jobs WHERE Jobs.Id = Assignment.Id AND (Current_Job IS NULL OR Current_Job = ' ') AND TILLS = 1

UPDATE Assignment
SET Shifts = CASE Assignment.Shifts WHEN '2' THEN '3'
									WHEN '0' THEN '5'
									END










 