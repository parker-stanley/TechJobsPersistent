--Part 1

--SELECT * from inner join on all tables

SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_SCHEMA = 'techjobs'
AND TABLE_NAME = 'Jobs';

-- OR

DESCRIBE Jobs;

--OR

SHOW COLUMNS FROM techjobs.jobs;

--Part 2

SELECT Names
FROM Employers
WHERE Location = "St. Louis City";

--Part 3

SELECT Name, Description
FROM Skills
INNER JOIN JobSkills ON Skills.Id = JobSkills.SkillId
ORDER BY Name ASC;