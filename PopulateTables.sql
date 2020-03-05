USE cmpt391; /*replace with your db name*/

/*delete all values in tables*/
delete from Department;
delete from Courses;
delete from Instructors;
delete from Students;

/*generated using https://mockaroo.com/ */

/*populate Department*/
INSERT INTO Department([Department_ID],[Head_Instructor_ID],[Name]) 
VALUES(1,16,'Anthropology'),(2,44,'Biological Sciences'),(3,18,'Computer Science'),
	  (4,57,'Economics'),(5,83,'English'),(6,100,'Humanities'),
	  (7,66,'Mathematics'),(8,3,'Physical Sciences'),(9,78,'Political Science'),
	  (10,36,'Psychology'),(11,73,'Sociology');

/*populate Courses*/


/*populate Instructors*/
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (1, 4, 'Jonah de Quincey', 'QuinceyJ@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (2, 7, 'Nealy De Clairmont', 'ClairmontN@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (3, 8, 'Shelley Lebel', 'LebelS@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (4, 11, 'Regine Pietzner', 'PietznerR@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (5, 4, 'Katheryn Likely', 'LikelyK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (6, 1, 'Imogen Duckit', 'DuckitI@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (7, 2, 'Willyt Hagland', 'HaglandW@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (8, 5, 'Brocky Tingly', 'TinglyB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (9, 2, 'Lacie Petran', 'PetranL@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (10, 7, 'Keith Liddel', 'LiddelK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (11, 11, 'Alex Borres', 'BorresA@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (12, 10, 'Mickey Siney', 'SineyM@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (13, 5, 'Veronike Frosch', 'FroschV@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (14, 5, 'Josepha Konertz', 'KonertzJ@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (15, 8, 'Pammy Andrivot', 'AndrivotP@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (16, 1, 'Wandie Llewellin', 'LlewellinW@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (17, 3, 'Vernice Woodard', 'WoodardV@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (18, 3, 'Kelcey Rablan', 'RablanK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (19, 3, 'Eadie Fidoe', 'FidoeE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (20, 10, 'Dniren Cosin', 'CosinD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (21, 1, 'Candice Bruna', 'BrunaC@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (22, 7, 'Willy Whodcoat', 'WhodcoatW@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (23, 9, 'Prissie Marcome', 'MarcomeP@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (24, 10, 'Brandea Gwinnett', 'GwinnettB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (25, 9, 'Pauline Lacasa', 'LacasaP@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (26, 4, 'Davis Howsam', 'HowsamD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (27, 4, 'Burty Wathen', 'WathenB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (28, 4, 'Dalenna Gambie', 'GambieD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (29, 3, 'Kissee Eminson', 'EminsonK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (30, 4, 'Ronnie Coverly', 'CoverlyR@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (31, 4, 'Jeannine Blasing', 'BlasingJ@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (32, 9, 'Letty Pusey', 'PuseyL@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (33, 2, 'Pippy Sidebotton', 'SidebottonP@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (34, 1, 'Yalonda Sowerbutts', 'SowerbuttsY@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (35, 1, 'Krisha Yukhnevich', 'YukhnevichK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (36, 10, 'Elnora Pfeffer', 'PfefferE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (37, 4, 'Ajay Klimpke', 'KlimpkeA@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (38, 2, 'Kari Flower', 'FlowerK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (39, 7, 'Daryl Jurek', 'JurekD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (40, 6, 'Sidney Collete', 'ColleteS@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (41, 6, 'Willow Ewell', 'EwellW@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (42, 6, 'Hatty Ayers', 'AyersH@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (43, 4, 'Phip Petrello', 'PetrelloP@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (44, 2, 'Nevil Dyne', 'DyneN@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (45, 10, 'Claribel Oldham', 'OldhamC@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (46, 4, 'Maryjane McPartlin', 'McPartlinM@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (47, 1, 'Basile Sollett', 'SollettB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (48, 4, 'Matthiew Pettyfar', 'PettyfarM@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (49, 5, 'Tull Quinnette', 'QuinnetteT@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (50, 8, 'Umeko Westall', 'WestallU@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (51, 3, 'Donia Bloxsome', 'BloxsomeD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (52, 4, 'Danika Luebbert', 'LuebbertD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (53, 8, 'Reagen Gorner', 'GornerR@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (54, 8, 'Morgen Cragg', 'CraggM@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (55, 8, 'Edin Booker', 'BookerE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (56, 11, 'Glenda Aked', 'AkedG@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (57, 4, 'Parry Ragat', 'RagatP@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (58, 10, 'Harold Garatty', 'GarattyH@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (59, 7, 'Vyky Olenchenko', 'OlenchenkoV@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (60, 11, 'Catrina Lysons', 'LysonsC@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (61, 7, 'Gusty Delooze', 'DeloozeG@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (62, 7, 'Cloris Booeln', 'BooelnC@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (63, 8, 'Raynor Figura', 'FiguraR@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (64, 4, 'Lolly Ranking', 'RankingL@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (65, 6, 'Karen Garthshore', 'GarthshoreK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (66, 7, 'Kaitlyn Nethercott', 'NethercottK@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (67, 10, 'Jarred Vickery', 'VickeryJ@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (68, 8, 'Bunni Menco', 'MencoB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (69, 11, 'Daisi By', 'ByD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (70, 7, 'Alanna Rutigliano', 'RutiglianoA@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (71, 3, 'Iorgo Pladen', 'PladenI@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (72, 1, 'Benoit Kindleysides', 'KindleysidesB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (73, 11, 'Brigid Shear', 'ShearB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (74, 8, 'Agretha Eastway', 'EastwayA@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (75, 8, 'Lucilia Fernier', 'FernierL@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (76, 7, 'Dorine Kasher', 'KasherD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (77, 7, 'Estell Vedeshkin', 'VedeshkinE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (78, 9, 'Ephrem Baswall', 'BaswallE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (79, 5, 'Minette Cathro', 'CathroM@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (80, 4, 'Elroy Hutchinson', 'HutchinsonE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (81, 7, 'Joellyn Sanday', 'SandayJ@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (82, 5, 'Frederich Wyrall', 'WyrallF@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (83, 5, 'Daryle Inkpin', 'InkpinD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (84, 9, 'Brunhilda Walters', 'WaltersB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (85, 9, 'Winonah Ziemke', 'ZiemkeW@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (86, 7, 'Desmund Jacmar', 'JacmarD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (87, 11, 'Elka Blenkinsop', 'BlenkinsopE@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (88, 10, 'Sal Prisley', 'PrisleyS@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (89, 5, 'Hillard Lavigne', 'LavigneH@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (90, 2, 'Brande Tomashov', 'TomashovB@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (91, 2, 'Justinian Quare', 'QuareJ@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (92, 1, 'La verne Zecchinelli', 'ZecchinelliL@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (93, 5, 'Hew Neames', 'NeamesH@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (94, 8, 'Gael Shillom', 'ShillomG@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (95, 8, 'Richie Rodolfi', 'RodolfiR@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (96, 8, 'Tierney Le Provest', 'ProvestT@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (97, 1, 'Doretta Wildbore', 'WildboreD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (98, 1, 'Harley Scough', 'ScoughH@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (99, 11, 'Devin Axon', 'AxonD@macewan.ca');
insert into Instructors (Instructor_ID, Department_ID, Name, Email) values (100, 6, 'Cyrill Creeboe', 'CreeboeC@macewan.ca');



/*populate Students*/


/*query all for testing purposes*/
--select * from Department;
--select * from Courses;
--select * from Instructors;
--select * from Students;