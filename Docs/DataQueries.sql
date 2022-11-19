USE [BugTracker]
GO

INSERT INTO [dbo].[Priorities]
           ([Name]
           ,[Description])

VALUES
    (
        'Very High',
		''
    ),
    (
        'High',
		''
    ),
	 (
        'Normal',
		''
    ),
	 (
        'Low',
		''
    ),
	 (
        'Very Low',
		''
    );
INSERT INTO [dbo].[Severities]
           ([Name]
           ,[Description])

VALUES
    (
        'A',
		'will cause the application to crash or to stop functioning'
    ),
    (
        'B',
		'will cause major problem troughout the application'
    ),
	 (
        'C',
		'will cause some problem troughout the application'
    ),
	 (
        'D',
		' will cause minimal problem troughout the application'
    ),
	(
        'E',
		' will cause minimal problem in a spcific part of the application'
    ),
	 (
        'F',
		'will only causes visual glitch'
    );

insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Dotty', 'Thurling', null, 70.16, 10, '9/29/2022', '3131 Scott Trail', 'dthurling0@amazon.co.uk', '3/4/1990');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Karoline', 'Hedau', 'Tax Accountant', 28.75, 37, '6/29/2022', '203 Lakeland Point', 'khedau1@earthlink.net', '5/29/2017');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Barry', 'Broadfield', null, 85.82, 2, '5/28/2022', '31 Esker Plaza', 'bbroadfield2@mac.com', '8/21/2005');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Dorri', 'Stairmond', 'Biostatistician III', 99.38, 44, '1/13/2022', '98 Drewry Plaza', 'dstairmond3@arizona.edu', '12/11/1998');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Zelma', 'Tuison', 'Internal Auditor', 66.68, 25, '4/17/2022', '77520 Hooker Park', null, '11/7/1952');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Rochella', 'Gaber', 'Junior Executive', 95.15, 41, '5/28/2022', '967 Glacier Hill Lane', 'rgaber5@dyndns.org', '1/9/2010');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jermain', 'Carleman', 'Operator', 80.53, 44, '1/20/2022', '38165 Cottonwood Road', null, '7/18/1958');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Christy', 'Caffery', 'Programmer Analyst IV', 58.03, 37, '10/17/2022', '62 Bluestem Way', null, '1/3/2014');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Byrle', 'Corbitt', 'Help Desk Operator', 40.91, 23, '7/24/2022', '4590 Coleman Avenue', 'bcorbitt8@taobao.com', '7/3/1952');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Reeta', 'Gillanders', 'Analyst Programmer', 64.27, 22, '10/4/2022', '4 Warbler Parkway', 'rgillanders9@bravesites.com', '11/1/1970');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kevan', 'Brightey', 'VP Product Management', 36.87, 32, '11/12/2022', '9720 Lindbergh Crossing', 'kbrighteya@nymag.com', '5/20/1984');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Barri', 'Saile', 'Sales Associate', 92.03, 56, '5/31/2022', '629 Monica Court', 'bsaileb@sun.com', '3/25/2002');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Serene', 'Skyner', 'Quality Engineer', 70.76, 30, '5/22/2022', '6553 Morrow Center', 'sskynerc@creativecommons.org', '4/18/2006');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Melinde', 'Dudbridge', 'Mechanical Systems Engineer', 98.71, 27, '4/30/2022', '350 Park Meadow Terrace', 'mdudbridged@i2i.jp', '6/2/1972');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Daron', 'McPeake', 'Dental Hygienist', 62.04, 22, '11/26/2021', '6432 Heath Trail', 'dmcpeakee@blogtalkradio.com', '6/9/2012');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Timmy', 'Campbell-Dunlop', 'Biostatistician III', 26.06, 49, '9/10/2022', '4 Blaine Place', 'tcampbelldunlopf@microsoft.com', '8/28/1972');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Alyce', 'Denkin', null, 44.38, 44, '9/1/2022', '8631 Kingsford Hill', 'adenking@dell.com', '6/11/1987');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Correy', 'Ames', 'Professor', 29.6, 28, '6/8/2022', '08 Leroy Junction', 'camesh@github.io', '9/21/1980');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Obediah', 'Plaster', 'Help Desk Technician', 14.22, 48, '12/18/2021', '09489 Commercial Drive', 'oplasteri@twitpic.com', '1/31/1998');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Linzy', 'Jonathon', 'Director of Sales', 21.82, 65, '2/13/2022', '9645 Holy Cross Way', 'ljonathonj@gnu.org', '4/21/1996');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Maible', 'Paule', 'Design Engineer', 27.77, 3, '2/6/2022', '4046 Canary Parkway', 'mpaulek@163.com', '3/24/1977');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nelli', 'Brason', 'Budget/Accounting Analyst I', 69.67, 48, '10/12/2022', '63297 Schiller Point', 'nbrasonl@newsvine.com', '8/18/1989');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nariko', 'Suermeier', 'Nuclear Power Engineer', 98.29, 22, '7/9/2022', '6 Mariners Cove Junction', 'nsuermeierm@goodreads.com', '4/9/1982');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Conroy', 'Burnham', 'Electrical Engineer', 31.98, 37, '2/22/2022', '94808 International Street', 'cburnhamn@google.com.au', '2/24/1960');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nat', 'McLenahan', 'Recruiter', 69.51, 5, '7/28/2022', '34964 Fulton Point', 'nmclenahano@economist.com', '3/8/2018');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Juieta', 'Hartzog', 'Community Outreach Specialist', 27.3, 36, '12/25/2021', '119 Anthes Lane', 'jhartzogp@opera.com', '6/13/1973');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Gwenni', 'Breming', 'Marketing Manager', 96.55, 48, '6/5/2022', '21495 Warrior Hill', 'gbremingq@auda.org.au', '10/14/1975');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Mignon', 'De Biasi', 'Nuclear Power Engineer', 84.51, 29, '7/7/2022', '5203 Vahlen Center', 'mdebiasir@prlog.org', '10/21/1982');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Valry', 'Botterman', 'Engineer IV', 97.1, 50, '11/7/2022', '43 Sheridan Lane', 'vbottermans@jugem.jp', '9/3/1996');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Chaunce', 'Gladdolph', 'Senior Quality Engineer', 99.39, 56, '2/18/2022', '8869 Golf View Court', 'cgladdolpht@dailymotion.com', '11/11/1997');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Layney', 'Pigott', 'Assistant Manager', 52.63, 19, '8/2/2022', '4442 Green Ridge Trail', 'lpigottu@parallels.com', '7/26/2017');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Noella', 'Wigg', 'Junior Executive', 97.67, 18, '1/30/2022', '60 Walton Junction', 'nwiggv@posterous.com', '6/16/2019');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Tawsha', 'Galbreath', 'Nurse', 76.45, 34, '6/19/2022', '8785 Dennis Place', 'tgalbreathw@imgur.com', '7/17/1984');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Lowell', 'Pollastrino', 'Safety Technician III', 45.65, 7, '5/22/2022', '08089 Fremont Lane', null, '12/13/1992');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ranna', 'McIlwaine', 'Executive Secretary', 33.83, 44, '5/20/2022', '638 Village Green Place', 'rmcilwainey@spotify.com', '1/26/2013');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Bradney', 'Welband', 'Registered Nurse', 42.42, 63, '1/4/2022', '08165 John Wall Circle', 'bwelbandz@who.int', '7/19/1985');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Freida', 'Ricketts', 'Teacher', 2.05, 20, '4/11/2022', '158 Morning Place', 'fricketts10@gravatar.com', '2/21/2021');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Arlinda', 'Buckleigh', 'Director of Sales', 94.28, 54, '6/23/2022', '7 Pond Court', 'abuckleigh11@webmd.com', '5/16/1960');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('William', 'Escalero', 'Dental Hygienist', 9.99, 29, '2/28/2022', '54 Pepper Wood Alley', 'wescalero12@rediff.com', '9/27/1967');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Gris', 'Fearby', 'Senior Financial Analyst', 14.93, 4, '6/5/2022', '34 Blaine Park', 'gfearby13@twitter.com', '3/31/2011');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Cleopatra', 'Melledy', 'Nuclear Power Engineer', 10.6, 49, '8/5/2022', '2 Carey Road', 'cmelledy14@nih.gov', '4/8/1967');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Skyler', 'Bailes', 'Information Systems Manager', 2.8, 42, '9/18/2022', '97154 Blaine Point', 'sbailes15@angelfire.com', '4/26/1965');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jeanna', 'Garrit', 'GIS Technical Architect', 77.24, 53, '12/20/2021', '0475 Moland Point', 'jgarrit16@furl.net', '6/18/2006');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jamil', 'Papez', null, 76.05, 2, '10/13/2022', '454 Tony Alley', 'jpapez17@deliciousdays.com', '12/20/1979');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kort', 'Barstock', 'Programmer II', 7.12, 53, '5/26/2022', '70 American Ash Alley', 'kbarstock18@example.com', '4/3/1972');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Warner', 'Laible', 'Geological Engineer', 74.51, 62, '1/10/2022', '785 Helena Center', 'wlaible19@technorati.com', '4/24/2003');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Matthiew', 'Redan', 'Assistant Media Planner', 71.77, 9, '4/20/2022', '84 Bowman Alley', 'mredan1a@360.cn', '11/15/1952');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Dela', 'Murrey', 'Junior Executive', 11.54, 29, '12/22/2021', '8764 Moulton Lane', 'dmurrey1b@hubpages.com', '7/31/1968');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Osborne', 'Chasemore', 'Product Engineer', 86.14, 25, '5/30/2022', '314 Kinsman Alley', 'ochasemore1c@yellowbook.com', '9/21/2009');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Maddie', 'Mallock', 'Software Engineer III', 14.28, 37, '6/12/2022', '8756 Everett Circle', 'mmallock1d@1688.com', '11/30/1962');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nance', 'Arkley', 'Programmer Analyst II', 20.76, 49, '7/20/2022', '1 Washington Road', 'narkley1e@google.pl', '1/21/1967');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Sheree', 'Gaspero', null, 24.03, 17, '12/30/2021', '12 Sycamore Parkway', null, '1/4/1986');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kayla', 'Yegorkov', 'Staff Scientist', 28.1, 16, '5/4/2022', '8845 Cherokee Place', 'kyegorkov1g@mayoclinic.com', '9/17/1951');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Mohandas', 'Van Haeften', 'Account Representative III', 44.21, 6, '11/16/2021', '0 Atwood Plaza', 'mvanhaeften1h@digg.com', '7/25/2015');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Vin', 'Cordaroy', 'Social Worker', 39.83, 17, '5/13/2022', '0 Lakeland Trail', 'vcordaroy1i@va.gov', '5/6/1958');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ulberto', 'Jammet', 'Office Assistant IV', 60.77, 17, '1/19/2022', '75 Sherman Place', 'ujammet1j@microsoft.com', '11/25/1985');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Linnet', 'Bosence', 'Senior Editor', 38.48, 20, '1/12/2022', '8 Summer Ridge Parkway', 'lbosence1k@wunderground.com', '5/23/1996');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kinsley', 'Davidof', 'Nurse Practicioner', 74.32, 43, '11/6/2022', '10386 Artisan Street', 'kdavidof1l@elpais.com', '8/13/1978');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Quill', 'Putson', 'Librarian', 44.13, 31, '7/19/2022', '11871 Warner Pass', 'qputson1m@devhub.com', '10/5/1986');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Abie', 'Bourtoumieux', 'Engineer III', 67.98, 50, '7/14/2022', '139 Buhler Terrace', 'abourtoumieux1n@gravatar.com', '8/15/1982');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Lilian', 'Senecaux', 'Clinical Specialist', 84.26, 35, '1/3/2022', '0 3rd Hill', 'lsenecaux1o@networksolutions.com', '2/20/1996');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('L;urette', 'Meininking', 'Director of Sales', 50.09, 4, '11/10/2022', '4610 Donald Lane', 'lmeininking1p@cbsnews.com', '2/22/2020');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Alleen', 'Hindrich', 'Assistant Manager', 87.31, 11, '10/30/2022', '61 Brickson Park Court', 'ahindrich1q@newsvine.com', '12/23/1959');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Glennis', 'Enevoldsen', 'Payment Adjustment Coordinator', 59.5, 12, '9/7/2022', '617 Sachs Street', 'genevoldsen1r@unc.edu', '4/12/2003');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Tandie', 'Bownes', 'Research Associate', 66.02, 26, '3/6/2022', '4 Jenifer Street', 'tbownes1s@discuz.net', '12/6/1983');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nichols', 'Corriea', 'Office Assistant IV', 30.0, 42, '4/27/2022', '44 Stone Corner Way', 'ncorriea1t@dedecms.com', '9/1/1963');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Shandra', 'Syddie', 'Staff Accountant I', 14.93, 12, '4/25/2022', '5964 Cambridge Plaza', 'ssyddie1u@blogtalkradio.com', '4/30/2021');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Bendicty', 'Kissell', 'Programmer Analyst I', 97.27, 31, '4/9/2022', '470 Maple Wood Pass', null, '10/10/1955');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Zebedee', 'Birney', 'Desktop Support Technician', 49.54, 23, '11/14/2022', '53 Arrowood Park', null, '10/4/1973');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Darcey', 'Pipes', 'Social Worker', 23.28, 24, '9/2/2022', '5 Fisk Way', 'dpipes1x@cmu.edu', '1/14/2017');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Shara', 'Laroze', 'Assistant Manager', 81.01, 42, '12/16/2021', '1177 Monument Alley', 'slaroze1y@tamu.edu', '4/15/2014');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ingaborg', 'Dowthwaite', 'Geologist IV', 99.1, 55, '12/13/2021', '150 Springview Road', 'idowthwaite1z@vistaprint.com', '7/12/1955');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Radcliffe', 'Iltchev', 'Structural Engineer', 74.26, 30, '4/28/2022', '99 Randy Court', 'riltchev20@jalbum.net', '11/20/1974');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jermaine', 'Meuse', 'Electrical Engineer', 1.03, 13, '4/29/2022', '70 Bowman Circle', 'jmeuse21@technorati.com', '3/21/1954');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Reid', 'Maryska', 'Accounting Assistant III', 10.54, 8, '4/13/2022', '747 Rieder Center', 'rmaryska22@so-net.ne.jp', '6/11/2015');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Hunter', 'Dowd', 'Help Desk Operator', 39.46, 35, '7/31/2022', '5628 Golf Parkway', 'hdowd23@opensource.org', '1/10/1984');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Simone', 'Manlow', 'Recruiter', 80.19, 5, '5/18/2022', '24 Birchwood Avenue', 'smanlow24@hud.gov', '2/26/2006');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Caritta', 'McVrone', 'Assistant Manager', 4.04, 24, '9/17/2022', '36 Almo Pass', 'cmcvrone25@slideshare.net', '4/21/2002');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Clair', 'Tenny', 'Administrative Officer', 62.37, 46, '2/18/2022', '425 Darwin Court', 'ctenny26@adobe.com', '7/7/1961');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Heddi', 'Fallis', 'Research Nurse', 2.09, 36, '2/7/2022', '117 Marquette Terrace', 'hfallis27@gravatar.com', '9/2/1955');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Daron', 'Adami', 'Programmer IV', 48.28, 28, '3/20/2022', '4911 Valley Edge Way', 'dadami28@ftc.gov', '12/2/1984');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Roderigo', 'Staff', 'Senior Sales Associate', 57.22, 6, '3/25/2022', '4905 Haas Avenue', 'rstaff29@sciencedirect.com', '11/22/1968');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Dorothy', 'Bittlestone', 'Financial Advisor', 65.69, 62, '6/17/2022', '35 Jenifer Court', 'dbittlestone2a@bbb.org', '12/2/1960');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Garvin', 'Overell', 'Dental Hygienist', 21.29, 5, '4/6/2022', '559 Sherman Court', null, '7/1/1993');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Roland', 'Tyrone', 'Recruiter', 76.13, 21, '9/6/2022', '6 Nancy Crossing', null, '5/17/1980');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jervis', 'Treat', 'Internal Auditor', 5.2, 49, '1/18/2022', '326 Stone Corner Avenue', 'jtreat2d@biglobe.ne.jp', '6/19/1980');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Godwin', 'Tomkys', 'Research Associate', 21.51, 46, '1/1/2022', '0716 Kingsford Lane', 'gtomkys2e@ucoz.com', '3/10/1981');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Daile', 'Noell', 'Senior Sales Associate', 10.12, 38, '3/19/2022', '13 Cardinal Pass', 'dnoell2f@elpais.com', '10/9/1972');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Bendick', 'Pawels', 'Recruiter', 64.95, 59, '5/14/2022', '359 Springs Avenue', null, '1/16/1973');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Gussie', 'Wardroper', 'Safety Technician I', 44.13, 63, '5/1/2022', '99480 Marcy Road', null, '3/20/1978');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Rici', 'Lemerie', 'Occupational Therapist', 58.56, 46, '3/10/2022', '971 Mosinee Road', 'rlemerie2i@fotki.com', '6/18/1999');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Normie', 'McBayne', 'Internal Auditor', 15.93, 21, '10/19/2022', '50867 Spaight Park', 'nmcbayne2j@indiatimes.com', '1/31/1995');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Buffy', 'Beven', 'Budget/Accounting Analyst III', 17.14, 32, '12/5/2021', '18367 Veith Lane', 'bbeven2k@google.de', '4/2/2012');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Buiron', 'McCaughran', 'Product Engineer', 56.85, 20, '8/12/2022', '29 Del Mar Pass', 'bmccaughran2l@ow.ly', '1/24/1993');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ernaline', 'Pee', 'Senior Cost Accountant', 29.55, 43, '12/5/2021', '02903 Heath Center', null, '1/19/1981');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kaitlin', 'Barehead', 'Director of Sales', 46.35, 7, '1/17/2022', '0212 Portage Point', 'kbarehead2n@huffingtonpost.com', '4/25/1976');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Joanne', 'Hannabus', 'Geological Engineer', 45.25, 2, '5/17/2022', '4 Bultman Plaza', 'jhannabus2o@1688.com', '1/21/1972');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Corabel', 'Shiell', 'Dental Hygienist', 89.66, 15, '6/13/2022', '7104 Loomis Avenue', 'cshiell2p@thetimes.co.uk', '4/12/1968');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Adrian', 'Lambert', 'Help Desk Technician', 56.2, 31, '11/15/2021', '625 Fordem Road', 'alambert2q@mozilla.com', '10/12/2009');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Charmion', 'Cheak', 'Marketing Assistant', 22.6, 20, '12/2/2021', '196 Logan Lane', 'ccheak2r@cmu.edu', '3/13/2007');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Margaret', 'Mulrenan', 'Quality Engineer', 17.4, 27, '1/31/2022', '2 Twin Pines Center', 'mmulrenan2s@ebay.com', '4/21/1996');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Sabina', 'Oneil', 'Speech Pathologist', 84.47, 40, '8/11/2022', '9 Eagle Crest Crossing', 'soneil2t@fc2.com', '7/8/2022');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ailis', 'Bister', 'Financial Analyst', 31.28, 37, '5/23/2022', '20058 Havey Terrace', null, '1/2/2004');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Patti', 'Gautrey', 'Design Engineer', 3.4, 56, '5/12/2022', '06 Garrison Hill', 'pgautrey2v@opensource.org', '7/23/1967');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Reinhard', 'Judkins', 'Design Engineer', 50.55, 53, '1/28/2022', '78587 Nobel Parkway', null, '3/14/1958');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Viva', 'Clout', 'Programmer I', 72.22, 63, '1/22/2022', '39 Eagan Circle', 'vclout2x@google.de', '8/21/2001');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Caralie', 'Frankis', 'Programmer I', 70.96, 35, '2/5/2022', '1767 Randy Way', 'cfrankis2y@bbc.co.uk', '5/15/1993');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Gwen', 'O'' Shea', 'Librarian', 45.8, 62, '9/21/2022', '07 Ridge Oak Way', 'goshea2z@hao123.com', '7/2/1978');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Sly', 'Pennuzzi', 'Associate Professor', 39.14, 62, '10/9/2022', '8032 Wayridge Hill', 'spennuzzi30@sourceforge.net', '4/14/1952');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Pearline', 'Held', 'Research Nurse', 24.02, 39, '12/28/2021', '1566 Pond Avenue', 'pheld31@seattletimes.com', '7/2/2009');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Johna', 'Houseman', 'Social Worker', 12.42, 65, '4/26/2022', '7 Division Avenue', 'jhouseman32@infoseek.co.jp', '8/8/1973');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Meredith', 'Campey', 'Research Assistant II', 10.96, 1, '4/11/2022', '1808 Canary Terrace', 'mcampey33@ed.gov', '5/7/2010');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Aarika', 'Nadin', 'Mechanical Systems Engineer', 96.66, 52, '3/30/2022', '47221 Beilfuss Point', 'anadin34@ed.gov', '1/31/2008');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Raf', 'Tupp', 'Financial Analyst', 40.28, 54, '4/13/2022', '3 Southridge Crossing', 'rtupp35@constantcontact.com', '2/25/1994');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Thorsten', 'Keuneke', 'Cost Accountant', 75.13, 27, '10/28/2022', '53 Straubel Drive', null, '5/20/1986');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Agosto', 'Beidebeke', 'Research Associate', 54.29, 38, '9/23/2022', '4 Mccormick Parkway', 'abeidebeke37@histats.com', '12/2/1990');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Shaine', 'Gibling', 'Database Administrator IV', 65.11, 5, '9/6/2022', '0 Fair Oaks Lane', 'sgibling38@deliciousdays.com', '11/1/1992');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Evan', 'Cockrell', 'Computer Systems Analyst II', 27.54, 10, '6/10/2022', '400 Becker Junction', 'ecockrell39@who.int', '8/16/1962');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Delcina', 'Bottomley', 'Database Administrator IV', 96.96, 28, '3/14/2022', '1 Kings Avenue', 'dbottomley3a@timesonline.co.uk', '1/30/1978');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Glennis', 'Dannett', 'Help Desk Technician', 13.69, 0, '12/15/2021', '02 Oneill Junction', 'gdannett3b@dell.com', '5/27/1965');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Roze', 'Usherwood', 'Account Coordinator', 64.6, 29, '10/7/2022', '98982 Butternut Crossing', 'rusherwood3c@moonfruit.com', '12/26/1960');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jaine', 'Greenig', 'Safety Technician III', 33.27, 45, '3/22/2022', '4 Darwin Street', 'jgreenig3d@tuttocitta.it', '9/19/2020');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Carissa', 'Aylwin', 'Graphic Designer', 45.2, 49, '6/21/2022', '53 Boyd Court', null, '7/9/2014');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ambrosius', 'Cicchinelli', 'Web Designer IV', 76.35, 20, '5/3/2022', '7 Macpherson Junction', 'acicchinelli3f@jimdo.com', '9/5/2021');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Rafaellle', 'Danilyuk', 'Editor', 68.25, 5, '3/23/2022', '474 Sunbrook Circle', 'rdanilyuk3g@soundcloud.com', '3/29/1956');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Elnora', 'Gallichan', 'Senior Financial Analyst', 3.31, 5, '11/22/2021', '14 Moose Avenue', null, '3/26/1951');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Flore', 'O''Brogane', 'Geologist IV', 40.7, 31, '7/3/2022', '27 Ramsey Center', 'fobrogane3i@digg.com', '2/10/1951');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ricki', 'De Cruce', 'Software Engineer IV', 3.49, 18, '3/24/2022', '73 Thierer Parkway', 'rdecruce3j@ameblo.jp', '9/22/1984');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Emory', 'Macartney', 'Mechanical Systems Engineer', 99.47, 42, '7/26/2022', '12801 Sage Junction', 'emacartney3k@java.com', '11/3/1991');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Had', 'McGenn', 'Structural Analysis Engineer', 25.88, 45, '4/29/2022', '1 Sullivan Alley', 'hmcgenn3l@youku.com', '3/14/2014');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Imogen', 'Emerton', 'Budget/Accounting Analyst III', 68.92, 19, '4/20/2022', '9971 Superior Way', 'iemerton3m@istockphoto.com', '1/30/1972');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Omar', 'Plumptre', 'Safety Technician IV', 96.79, 56, '2/2/2022', '8 Eastlawn Crossing', 'oplumptre3n@pbs.org', '12/24/1984');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Tiffany', 'Sarson', 'Staff Scientist', 70.26, 12, '9/3/2022', '51 Waywood Road', 'tsarson3o@springer.com', '7/23/1971');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Retha', 'Pymer', 'Software Consultant', 52.16, 32, '8/14/2022', '45297 4th Way', 'rpymer3p@storify.com', '2/3/1998');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Alonzo', 'Terrell', 'Health Coach I', 66.23, 8, '1/2/2022', '93 Bluejay Point', 'aterrell3q@house.gov', '10/22/1993');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Pippa', 'Gerriets', 'Data Coordiator', 70.97, 47, '8/15/2022', '2 Gulseth Pass', 'pgerriets3r@boston.com', '6/17/1994');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Elfie', 'Gores', 'Sales Associate', 8.58, 18, '10/24/2022', '0176 Sullivan Hill', 'egores3s@tuttocitta.it', '10/17/1989');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Burlie', 'Emsley', 'VP Sales', 22.54, 39, '3/13/2022', '00517 Transport Circle', 'bemsley3t@seesaa.net', '6/12/2003');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Hersch', 'Cordingley', 'Web Developer II', 2.14, 43, '6/9/2022', '9758 Shelley Way', 'hcordingley3u@barnesandnoble.com', '1/10/1985');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Deedee', 'Reith', 'Pharmacist', 29.61, 48, '11/20/2021', '9 Veith Crossing', 'dreith3v@bizjournals.com', '4/28/1981');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Becka', 'McGraw', 'Help Desk Technician', 47.21, 4, '10/1/2022', '596 Emmet Drive', 'bmcgraw3w@google.ru', '8/6/2003');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Chaim', 'Sambeck', 'Human Resources Assistant I', 21.33, 22, '2/5/2022', '42340 Oak Road', 'csambeck3x@europa.eu', '7/13/2001');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Derrik', 'Flaunier', 'Community Outreach Specialist', 35.18, 65, '3/4/2022', '946 Ridgeview Crossing', 'dflaunier3y@psu.edu', '1/18/1989');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Teddie', 'Blagden', 'Analyst Programmer', 58.19, 43, '7/24/2022', '8388 Homewood Street', 'tblagden3z@census.gov', '5/12/2004');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Matty', 'Matveichev', 'Nurse Practicioner', 88.94, 32, '5/19/2022', '3965 Quincy Park', 'mmatveichev40@com.com', '1/31/1982');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Cornie', 'MacCracken', 'VP Sales', 35.78, 15, '8/22/2022', '35 Myrtle Center', 'cmaccracken41@soup.io', '6/22/1991');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Carroll', 'Summons', 'Associate Professor', 18.34, 21, '1/22/2022', '57901 Dottie Point', 'csummons42@google.ru', '4/28/1989');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Homerus', 'Minall', 'VP Marketing', 56.24, 6, '4/27/2022', '3662 Russell Plaza', 'hminall43@comsenz.com', '8/25/1996');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Gerty', 'Andreini', 'Community Outreach Specialist', 23.63, 40, '11/2/2022', '28 Maryland Pass', 'gandreini44@usnews.com', '6/20/2018');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Marlena', 'Turneux', 'VP Quality Control', 88.76, 15, '6/30/2022', '94920 Red Cloud Crossing', 'mturneux45@upenn.edu', '3/1/2005');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Rodd', 'Madelin', 'Software Consultant', 48.99, 59, '7/23/2022', '995 Sundown Center', 'rmadelin46@comsenz.com', '10/29/1968');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Reginald', 'Ruit', 'Developer II', 54.22, 9, '6/24/2022', '6261 Monterey Lane', 'rruit47@shareasale.com', '12/11/1987');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Emyle', 'MacCurtain', 'Senior Editor', 21.61, 50, '10/5/2022', '4755 Menomonie Plaza', 'emaccurtain48@narod.ru', '11/22/1953');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Natale', 'Genny', 'Web Developer III', 1.37, 42, '2/24/2022', '4891 Pankratz Road', null, '7/24/2016');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Shaine', 'Brantl', 'Design Engineer', 35.07, 46, '2/4/2022', '418 Moose Place', 'sbrantl4a@icq.com', '8/20/1955');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Lisha', 'La Grange', 'Senior Cost Accountant', 62.33, 18, '9/5/2022', '10431 Merchant Crossing', 'llagrange4b@wired.com', '5/2/2017');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Dorthea', 'Behrens', 'Mechanical Systems Engineer', 49.37, 56, '2/3/2022', '10242 Comanche Circle', 'dbehrens4c@github.io', '8/3/2001');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Bennie', 'Slayton', 'Research Associate', 62.62, 7, '11/28/2021', '6 Macpherson Road', 'bslayton4d@joomla.org', '1/30/2011');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Verine', 'Fontelles', 'Dental Hygienist', 12.34, 18, '11/1/2022', '083 Cherokee Avenue', 'vfontelles4e@wordpress.com', '4/4/1992');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nicol', 'Nower', 'Geologist IV', 75.41, 51, '12/11/2021', '14 Eagle Crest Plaza', 'nnower4f@live.com', '9/12/2017');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Aeriel', 'Girardet', 'Programmer Analyst IV', 56.67, 43, '6/29/2022', '26775 Oxford Trail', 'agirardet4g@xrea.com', '9/7/1961');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Aubrey', 'Goldhawk', 'Statistician I', 80.57, 5, '6/14/2022', '82 Anthes Crossing', 'agoldhawk4h@simplemachines.org', '1/19/1987');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Edouard', 'Ord', 'Senior Cost Accountant', 37.7, 7, '6/22/2022', '14188 Eastlawn Crossing', 'eord4i@china.com.cn', '11/9/1959');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Belvia', 'Caughey', 'Senior Developer', 26.9, 44, '7/5/2022', '37 Vermont Place', 'bcaughey4j@bing.com', '12/21/1962');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Sherill', 'Caudrelier', 'Editor', 33.17, 43, '2/21/2022', '2 Steensland Trail', 'scaudrelier4k@nhs.uk', '6/2/2017');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Sherri', 'Duiged', 'Structural Engineer', 43.55, 17, '2/21/2022', '35203 Northport Place', 'sduiged4l@digg.com', '1/25/1999');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Eada', 'Whitehead', 'Electrical Engineer', 5.04, 55, '3/6/2022', '5 Dapin Alley', 'ewhitehead4m@chicagotribune.com', '5/24/1985');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Miriam', 'Saket', 'Sales Representative', 83.75, 0, '6/4/2022', '2989 Bluejay Circle', 'msaket4n@wikispaces.com', '6/2/2021');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Codi', 'Plowes', 'Senior Quality Engineer', 27.15, 29, '7/27/2022', '9623 Gale Junction', 'cplowes4o@house.gov', '3/22/1989');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Blondell', 'Bandiera', 'Recruiting Manager', 71.0, 30, '2/17/2022', '50042 Charing Cross Trail', 'bbandiera4p@eventbrite.com', '8/15/1956');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Samara', 'Birth', null, 45.33, 36, '11/16/2021', '26820 Bellgrove Street', 'sbirth4q@wikimedia.org', '5/30/1958');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Stormy', 'Stoffel', 'Software Engineer I', 80.83, 62, '11/23/2021', '71756 Arrowood Street', 'sstoffel4r@multiply.com', '9/10/2007');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Veronika', 'Delmonti', 'Data Coordiator', 97.16, 16, '2/24/2022', '567 Oneill Junction', 'vdelmonti4s@goo.ne.jp', '12/27/1961');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Mal', 'Golsworthy', 'Director of Sales', 23.5, 10, '11/4/2022', '942 Hoard Place', null, '2/13/1982');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Marcelle', 'Werner', 'Account Coordinator', 73.6, 26, '10/4/2022', '174 Homewood Terrace', 'mwerner4u@bloglines.com', '4/12/2002');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Shandra', 'Juppe', 'Research Associate', 23.97, 34, '12/13/2021', '730 Swallow Place', 'sjuppe4v@infoseek.co.jp', '7/26/2002');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Meryl', 'McLardie', 'Account Coordinator', 67.23, 57, '8/11/2022', '255 Division Circle', 'mmclardie4w@about.me', '4/24/1969');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Berkie', 'Ingliby', 'Design Engineer', 3.01, 33, '9/19/2022', '48 Derek Road', 'bingliby4x@purevolume.com', '10/23/1983');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Daryl', 'Luno', 'Structural Engineer', 91.75, 37, '4/24/2022', '1 Aberg Road', 'dluno4y@independent.co.uk', '8/3/1954');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ivory', 'Skittle', 'Sales Associate', 34.43, 4, '5/8/2022', '3781 Towne Alley', 'iskittle4z@soundcloud.com', '2/26/2003');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ulrich', 'Gilphillan', null, 6.82, 15, '10/22/2022', '5406 Granby Junction', 'ugilphillan50@google.pl', '5/13/1956');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kent', 'Barnwille', 'Technical Writer', 72.11, 17, '8/22/2022', '06 Welch Avenue', 'kbarnwille51@amazon.co.jp', '4/26/2007');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Lenora', 'Vasyukhichev', 'Research Nurse', 97.98, 27, '3/13/2022', '4034 Debs Point', 'lvasyukhichev52@odnoklassniki.ru', '8/29/2007');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Gay', 'Cowlard', 'Community Outreach Specialist', 68.72, 47, '7/2/2022', '3674 Menomonie Way', 'gcowlard53@chronoengine.com', '1/18/2019');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Kimble', 'Hubert', 'Professor', 59.48, 0, '6/10/2022', '883 Talisman Road', 'khubert54@photobucket.com', '9/5/2018');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jada', 'Dibsdale', 'Geologist IV', 66.71, 27, '5/26/2022', '082 Rieder Hill', 'jdibsdale55@nationalgeographic.com', '11/8/2019');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Mozes', 'Quittonden', 'Legal Assistant', 79.74, 50, '1/6/2022', '07 Morning Lane', 'mquittonden56@state.tx.us', '5/5/2013');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Justus', 'Labram', 'Software Test Engineer II', 58.51, 16, '4/27/2022', '9 Chinook Avenue', 'jlabram57@photobucket.com', '5/15/2008');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ashleigh', 'Derill', 'VP Accounting', 57.81, 59, '7/22/2022', '45948 Brickson Park Trail', 'aderill58@sogou.com', '10/24/1952');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Marlin', 'Cussons', 'Environmental Tech', 34.49, 0, '6/29/2022', '37 Sullivan Way', 'mcussons59@businesswire.com', '10/15/1993');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Marjy', 'Grafham', null, 72.3, 32, '2/9/2022', '71210 Glendale Point', 'mgrafham5a@virginia.edu', '1/29/1990');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Lindi', 'Callicott', 'Budget/Accounting Analyst I', 60.26, 32, '11/8/2022', '01356 Porter Road', 'lcallicott5b@kickstarter.com', '10/3/1966');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Letisha', 'Bashford', 'Software Test Engineer IV', 40.34, 53, '12/2/2021', '69768 Union Trail', null, '2/23/1976');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Jaclin', 'Montgomery', 'Account Executive', 88.86, 55, '8/10/2022', '72366 Cody Lane', 'jmontgomery5d@theguardian.com', '2/7/2006');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Godwin', 'Vidler', 'Assistant Professor', 44.16, 4, '7/6/2022', '33757 Mesta Circle', 'gvidler5e@nytimes.com', '4/26/1986');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Nikolas', 'Beauvais', 'VP Accounting', 70.4, 52, '7/27/2022', '0 Independence Center', 'nbeauvais5f@businessweek.com', '11/18/2002');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Ricardo', 'Dyball', 'Operator', 88.4, 30, '2/2/2022', '604 Rusk Drive', 'rdyball5g@cornell.edu', '9/14/2000');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Robb', 'Mixhel', 'Junior Executive', 70.75, 28, '5/15/2022', '71 Ronald Regan Parkway', 'rmixhel5h@biblegateway.com', '4/20/2018');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Laurice', 'Beadell', 'Graphic Designer', 30.62, 44, '3/12/2022', '7798 Prairie Rose Road', 'lbeadell5i@fema.gov', '7/9/1978');
insert into People (FirstName, LastName, JobTitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth) values ('Janelle', 'Lapsley', 'Executive Secretary', 10.25, 28, '7/31/2022', '5337 Daystar Trail', 'jlapsley5j@e-recht24.de', '10/5/2000');

USE [BugTracker]
GO
DBCC CHECKIDENT (Bugs, RESEED, 0)

INSERT INTO [dbo].[Bugs]
           ([bugName]
           ,[Description]
           ,[CreatorId]
           ,[PriorityId]
           ,[SeverityId]
           ,[CreationDate]
           ,[LastUpDate]
           ,[Solved])
     VALUES
           ('A very serious bug',
           '', 
           1,
           1,
           1, 
           '2022-10-10 00:00:00.0000000',
           '2022-10-10 00:00:00.0000000',
           'false');


INSERT INTO [dbo].[Messages]
           ([BugId]
           ,[CreatorId]
           ,[Text]
           ,[Created])
     VALUES
           (1,
           1,
           'Hello World',
           '2022-10-10 00:00:00.0000000');


INSERT INTO [dbo].[Logs]
           ([BugId]
           ,[Message]
           ,[Created])
     VALUES
           (1,
           'Bug created!',
           '2022-10-10 00:00:00.0000000');
		   go


