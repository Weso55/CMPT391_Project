GO
CREATE OR ALTER VIEW detail
WITH SCHEMABINDING
AS
SELECT Courses.Course_ID AS Class_ID, Courses.Name AS C_Name, Courses.Section_ID AS S_ID, Instructors.Name AS I_name, Courses.Semester AS Semester, Courses.Year AS Year, Department.Name AS D_name, Courses.Capacity AS cap   
FROM dbo.Courses, dbo.Instructors, dbo.Department  
WHERE Courses.Instructor_ID = Instructors.Instructor_ID AND Instructors.Department_ID = Department.Department_ID;

GO
CREATE UNIQUE CLUSTERED INDEX index1
ON detail(Class_ID, S_ID, Semester, Year)