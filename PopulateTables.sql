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
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(1,6,'Ashton Odom','lobortis.quis.pede@viverraDonectempus.ca'),(2,4,'Dennis Olsen','metus.Aenean.sed@semNulla.net'),(3,7,'Evelyn Madden','placerat.eget.venenatis@dolortempus.ca'),(4,4,'Keane Hicks','fermentum.risus.at@Sed.org'),(5,4,'Kylan Robbins','sem@rutrummagna.net'),(6,10,'Ingrid Webster','vitae@volutpatNullafacilisis.edu'),(7,6,'Ray Dickson','mi.pede@nequevitaesemper.co.uk'),(8,6,'Oren House','semper.egestas@Sed.ca'),(9,8,'Olga Ballard','amet.massa.Quisque@acorciUt.net'),(10,7,'Eugenia Shaffer','ante@eratnonummyultricies.co.uk'),(11,7,'Aladdin Hodge','urna@eratnonummyultricies.edu');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(12,11,'Nicole Church','venenatis@Duissit.org'),(13,2,'Josiah Banks','tellus.Suspendisse@mattis.org'),(14,7,'Kane Quinn','sed@lobortisauguescelerisque.org'),(15,7,'Bruce Poole','Nunc@turpis.com'),(16,5,'Hasad Rivera','ac@semperduilectus.co.uk'),(17,2,'Shana Stout','faucibus.Morbi@Fuscedolor.net'),(18,10,'Haviva Watkins','interdum.libero.dui@ac.com'),(19,1,'Kevyn Lancaster','posuere.vulputate@orcilobortis.edu'),(20,11,'Ryder Donaldson','Curae@sitamet.com'),(21,8,'Ryder Small','eu@aliquet.co.uk'),(22,4,'Mollie Knowles','luctus.sit.amet@ipsumprimisin.co.uk');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(23,6,'Kaseem Rodgers','sit@orcitinciduntadipiscing.co.uk'),(24,4,'Vivien Fletcher','elementum.purus.accumsan@Sed.ca'),(25,10,'Kadeem Lyons','penatibus@Fuscemi.org'),(26,4,'Belle Maddox','pellentesque@molestietortornibh.org'),(27,9,'Lydia England','lacus.vestibulum.lorem@Aliquam.ca'),(28,10,'Libby Cannon','Proin@nisiaodio.com'),(29,3,'Fatima Wood','dignissim.magna@egestas.co.uk'),(30,4,'Halee Rivera','eu.neque.pellentesque@quam.org'),(31,11,'Nicole Dudley','imperdiet.nec@odioNaminterdum.ca'),(32,1,'Lester Bolton','orci.Donec.nibh@elementumpurusaccumsan.edu'),(33,2,'Stephanie Rivera','auctor.velit@scelerisquescelerisquedui.org');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(34,11,'Petra Bright','mi.felis@id.com'),(35,4,'Derek Whitaker','turpis@eueros.co.uk'),(36,11,'Solomon Donovan','suscipit.nonummy.Fusce@Cras.net'),(37,10,'Leandra Jackson','tincidunt.pede@parturient.co.uk'),(38,1,'Basia Park','dolor@lobortisClassaptent.net'),(39,8,'Veda Vance','eu@egestasnunc.co.uk'),(40,3,'Anastasia Rutledge','nec@nequeNullam.edu'),(41,10,'Benedict Velez','elit.pede.malesuada@Aliquamnisl.co.uk'),(42,8,'Melvin Erickson','bibendum@orciinconsequat.co.uk'),(43,6,'John Gallagher','elit.erat.vitae@anunc.edu'),(44,1,'Hammett Vaughn','Sed.eu@placerataugue.co.uk');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(45,11,'Uma Sanders','nec@Aliquam.co.uk'),(46,9,'Samson Webb','Donec.tempus@risusa.edu'),(47,1,'Philip Lloyd','eu@a.com'),(48,11,'Zachary Drake','tempor.erat@eros.net'),(49,10,'Callum Guzman','pede@tortorNunc.edu'),(50,9,'Yuli Knapp','consequat.enim@sagittis.net'),(51,11,'Nigel Ramsey','In.at.pede@tellusidnunc.com'),(52,3,'Hanae Short','amet@sedsem.com'),(53,3,'Bryar Livingston','mi.fringilla@feugiat.edu'),(54,11,'Sybil Walters','porttitor.eros.nec@turpis.co.uk'),(55,3,'Ariel Larsen','in.dolor.Fusce@dolortempusnon.co.uk');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(56,7,'George Mcintyre','tristique.pellentesque.tellus@eleifendnon.net'),(57,5,'Barrett Walton','Sed.congue@idnunc.edu'),(58,2,'Berk Dillon','velit@commodoauctor.org'),(59,4,'Zachary Ferguson','enim.Etiam@Morbiquisurna.ca'),(60,6,'Paula Fleming','convallis.erat.eget@nuncullamcorper.net'),(61,1,'Zorita Roy','et.euismod.et@ategestas.com'),(62,2,'Germaine Parsons','sit.amet@fringilla.org'),(63,8,'Devin Collins','bibendum@orciDonec.edu'),(64,2,'Renee Kim','eget.lacus@ullamcorperDuiscursus.ca'),(65,9,'Whoopi Foreman','ligula.Aenean@tellusjusto.org'),(66,3,'Alma Camacho','commodo.auctor.velit@elitsedconsequat.com');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(67,9,'Emerald Rojas','ante@magnaaneque.co.uk'),(68,9,'Rogan Stuart','enim.Sed@hendreritnequeIn.co.uk'),(69,8,'Keith Norris','a.purus@risus.org'),(70,7,'Serena Small','at.libero.Morbi@ategestasa.com'),(71,2,'Germane Cotton','nunc@esttemporbibendum.edu'),(72,1,'Ralph Bailey','malesuada.id.erat@tellussem.edu'),(73,11,'Kenneth Travis','tristique@bibendum.org'),(74,8,'Daria Saunders','Nullam.velit@ametante.com'),(75,10,'Oren Sanford','sollicitudin.a.malesuada@sitametconsectetuer.edu'),(76,3,'Carly Rhodes','convallis@blanditenimconsequat.com'),(77,1,'Aline Hess','aliquet.nec@scelerisqueneque.com');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(78,6,'Kylee Winters','ornare@Vivamussitamet.net'),(79,11,'Samantha Oneal','libero@placerategetvenenatis.org'),(80,11,'Indira Farrell','et@mattis.org'),(81,1,'Lars Fisher','arcu.iaculis@MaurismagnaDuis.ca'),(82,8,'Robin Prince','taciti@Sedeu.ca'),(83,11,'Hall Erickson','mus.Donec@nisi.net'),(84,2,'Bruce Reese','mauris.blandit.mattis@mi.edu'),(85,3,'Silas Thornton','ante.blandit@eleifendnunc.edu'),(86,9,'Ginger Stephenson','odio.Phasellus@magnatellusfaucibus.co.uk'),(87,9,'Whilemina Floyd','volutpat.Nulla.facilisis@nonquam.com'),(88,10,'Camille Salinas','pede@purusgravidasagittis.ca');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(89,9,'Lev Juarez','In.at@felis.co.uk'),(90,2,'Raymond Alston','Cras@parturientmontesnascetur.edu'),(91,5,'Stephanie Calderon','Vestibulum.accumsan.neque@Integertincidunt.edu'),(92,11,'Tate Ryan','Sed@et.org'),(93,11,'Amena Wiley','Mauris@mattis.ca'),(94,2,'Shafira Becker','nisi.Aenean.eget@interdumenim.com'),(95,5,'Marshall Lynn','est@dapibusgravidaAliquam.ca'),(96,4,'Ciara Hurst','blandit.mattis@Aliquam.com'),(97,8,'Brooke Moss','mi.felis.adipiscing@vestibulumnec.edu'),(98,7,'Dana Charles','amet@Aeneaneget.co.uk'),(99,5,'Zenaida Wilder','pede@lectusa.co.uk');
INSERT INTO Instructors([Instructor_ID],[Department_ID],[Name],[Email]) VALUES(100,5,'Kimberley Hanson','ac@elit.ca');

/*populate Students*/


/*query all for testing purposes*/
select * from Department;
select * from Courses;
select * from Instructors;
select * from Students;