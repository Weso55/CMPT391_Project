USE cmpt391; /*replace with your db name*/

/*delete all values in tables*/
delete from Department;
delete from Courses;
delete from Instructors;
delete from Students;

/*generated using https://www.generatedata.com/ */

/*populate Department*/
INSERT INTO Department([Department_ID],[Head_Instructor_ID],[Name]) 
VALUES(1,1,'Anthropology'),(2,2,'Biological Sciences'),(3,3,'Computer Science'),
	  (4,4,'Economics'),(5,5,'English'),(6,6,'Humanities'),
	  (7,7,'Mathematics'),(8,8,'Physical Sciences'),(9,9,'Political Science'),
	  (10,10,'Psychology'),(11,11,'Sociology');

/*populate Courses*/


/*populate Instructors*/

/*populate Students*/


/*query all for testing purposes*/
select * from Department;
select * from Courses;
select * from Instructors;
select * from Students;