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

write a query to return a list of the names
and descriptions of all skills that are attached to jobs
in alphabetical order.
If a skill does not have a job listed, it should not be included in the results of this query.

SELECT Name, Description
FROM techjobs.Jobs
INNER JOIN Skills ON Jobs.Id = JobSkills.Job.Id
WHERE Job is not null
ORDER BY Name DESC;

-- this is better
SELECT Name, Description
FROM Skills
INNER JOIN JobSkills ON Skills.Id = JobSkills.SkillId
ORDER BY Name ASC;