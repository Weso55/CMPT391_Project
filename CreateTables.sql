USE cmpt391; /*replace with your db name*/

DROP TABLE [Students];
DROP TABLE [Department];
DROP TABLE [Instructors];
DROP TABLE [Prereq];
DROP TABLE [Courses];
DROP TABLE [Enrolled];
                                                                    
CREATE TABLE [Students] (
  [Student_ID] INT,
  [Name] VARCHAR(50),
  [Email] VARCHAR(50),
  PRIMARY KEY ([Student_ID])
);

CREATE TABLE [Department] (
  [Department_ID] INT,
  [Head_Instructor_ID] INT,
  [Name] VARCHAR(50),
  PRIMARY KEY ([Department_ID])
);

CREATE INDEX [FK] ON  [Department] ([Head_Instructor_ID]);

CREATE TABLE [Instructors] (
  [Instructor_ID] INT,
  [Department_ID] INT,
  [Name] VARCHAR(50),
  [Email] VARCHAR(50),
  PRIMARY KEY ([Instructor_ID])
);

CREATE INDEX [FK] ON  [Instructors] ([Department_ID]);

CREATE TABLE [Prereq] (
  [Course_id] INT,
  [prereq_id] INT,
  PRIMARY KEY ([Course_id], [prereq_id])
);

CREATE TABLE [Courses] (
  [Course_ID] INT,
  [Department_ID] INT,
  [Instructor_ID] INT,
  [Section_ID] VARCHAR(10),
  [Semester] VARCHAR(50),
  [Year] INT,
  [Name] VARCHAR(50),
  [Capacity] INT,
  PRIMARY KEY ([Course_ID], [Section_ID], [Semester], [Year])
);

CREATE INDEX [FK] ON  [Courses] ([Department_ID], [Instructor_ID]);

CREATE TABLE [Enrolled] (
  [Student_ID] INT,
  [Course_ID] INT,
  [Section_ID] VARCHAR(10),
  [Semester] VARCHAR(50),
  [Year] INT,
  PRIMARY KEY ([Student_ID], [Course_ID], [Section_ID], [Semester], [Year])
);

                                                                
