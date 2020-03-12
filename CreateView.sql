CREATE VIEW detail AS
SELECT Courses.Course_ID AS Class_ID, Courses.Name AS C_Name, Courses.Section_ID AS S_ID,Instructors.Name AS I_name,Department.Name AS D_name,Courses.Capacity AS cap   
FROM Courses,Instructors,Department  
WHERE Courses.Department_ID = Department.Department_ID AND Instructors.Department_ID = Department.Department_ID