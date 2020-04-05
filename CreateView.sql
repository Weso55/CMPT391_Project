GO
CREATE OR ALTER VIEW detail
WITH SCHEMABINDING
AS
SELECT Courses.Course_ID AS Class_ID, Courses.Name AS C_Name, Courses.Section_ID AS S_ID, Instructors.Name AS I_name, Courses.Semester AS Semester, Courses.Year AS Year, Department.Name AS D_name, Courses.Capacity AS cap   
FROM dbo.Courses, dbo.Instructors, dbo.Department  
WHERE Courses.Instructor_ID = Instructors.Instructor_ID AND Instructors.Department_ID = Department.Department_ID;

GO
CREATE UNIQUE CLUSTERED INDEX ind_detail1
ON detail(Class_ID, S_ID, Semester, Year);

GO
CREATE OR ALTER VIEW courseview
WITH SCHEMABINDING
AS
SELECT Course_ID, Department.Name AS "Department Name", Instructors.Name AS "Instructor Name", Courses.Section_ID, Courses.Semester, Courses.Year, Courses.Name, Courses.Capacity
FROM dbo.Courses, dbo.Instructors, dbo.Department
WHERE Courses.Instructor_ID = Instructors.Instructor_ID AND Courses.Department_ID = Department.Department_ID;

GO
CREATE UNIQUE CLUSTERED INDEX ind_course1
ON courseview(Course_ID, Section_ID, Semester, Year);