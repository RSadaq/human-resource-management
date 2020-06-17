SELECT * FROM Assignment;
--SELECT Name FROM Assignment WHERE Current_Job IS NULL OR Current_Job = ' ';
--SELECT Name, Current_Job FROM Assignment;

UPDATE Assignment
SET Current_Job = 'Blah', Shifts = '300'
WHERE (Current_Job IS NULL OR Current_Job = ' ' AND Name = 'John Knight');