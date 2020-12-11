--Part 1

--SELECT * from inner join on all tables

SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_SCHEMA = 'techjobs'
AND TABLE_NAME = 'table_name';

-- OR

DESCRIBE mytable --placeholder

--OR

SHOW COLUMNS FROM techjobs.mytable --placeholder

--Part 2

SELECT Names
FROM Employers
WHERE Location == "St. Louis City";

--Part 3

write a query to return a list of the names
and descriptions of all skills that are attached to jobs
in alphabetical order.
If a skill does not have a job listed, it should not be included in the results of this query.

SELECT Name
FROM techjobs.Jobs
INNER JOIN JobSkills ON Jobs.Id = JobSkills.Job.Id;