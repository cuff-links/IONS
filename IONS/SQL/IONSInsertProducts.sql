
--Insert default values for internet plans into PRODUCT Table
Insert into PRODUCT Values
('SNLDU', '56K Snail Dial-up', 'Dial-up internet access using land-line. Most economic option for light internet users.', '56kpbs/28kbps' , NULL,  9.95 , 'Dial-Up' , 'Internet' ,  NULL);

Insert into PRODUCT Values
('FRG3MB', '3.0MB Frog DSL', 'High Speed Internet access over a dedicated phone line. Does not tie up line while surfing the internet. Has higher speeds and less connection drops than dialup. ', '3.0mbps/768kbps',NULL,  19.95 , 'DSL' , 'Internet' ,  NULL);

Insert into PRODUCT Values
('SQRL10MB', '10.0MB Squirrel DSL', 'High speed internet access over a dedicated phone line. Over 3 times faster than Frog DSL. Can be used for multiple devices around the home.', '10mpbs/1.5mbps',NULL , 39.95 , 'DSL' , 'Internet' ,  NULL);

Insert into PRODUCT Values
('ELE25MB', '25.0MB Elephant Cable','High speed internet access through "cable" or coaxial lines. Offers higher speeds than all DSL options but the connetion is shared through the neighborhood and is subject to fluxuation.' , '25mbps/2mpbs' , NULL,  69.95 , 'Cable' , 'Internet' ,  NULL);

Insert into PRODUCT Values
('CBL40MB', '40.0MB Bear Cable','High speed internet access through "cable" or coaxial lines. This is almost twice as fast as the Elephant Cable option and is good for homes with a wide array of internet enabled devices. Comes with free home networking.', '40mpbs/5mbps' ,NULL ,89.95 , 'Cable' , 'Internet' ,  NULL);

Insert into PRODUCT Values
('OSCH75MB', '75.0MB Ostrich FiOs','High speed internet access through fiber optic lines. Far more powerful than the DSL and Cable options. Each fiber line is ran directly to the premise so there is no connection fluctuation. This service is well suited for home based businesses to run their operations as well as home based servers.','75mpbs/7.5mpbs' , NULL, 109.95 , 'Fiber Optics' , 'Internet' ,  NULL);

Insert into PRODUCT Values
('CHTH100MB', '100.0MB Cheetah FiOs', 'While this solution is not one that everyone will partake of, those that do will not be able to use anything else. This connection would be able to run any of your household operations without a hitch. We even have a 6 month guarantee. If you are not satisfied with the speed of our Cheetah FiOs, we will give you a full refund of all 6 months.', '100mpbs/10mpbs',NULL , 149.95 , 'Fiber Optics' , 'Internet' ,  NULL);

--Insert default values for phone plans into PRODUCT table
Insert into PRODUCT VALUES
('SNLPH1', 'Snail Basic Line' , 'Basic telephone line with no features. Gives you a clear connection to the world. Most economic option for light users.', 'None', NULL, 10.99,NULL  , 'Phone' ,  NULL);

Insert into PRODUCT VALUES
('SQRLPH1','Squirrel Package' , 'A convenient little package with the two most desired features. Caller ID and Call Waiting.', 'CID, CW',NULL,  22.99, NULL , 'Phone' ,  NULL);

Insert into PRODUCT VALUES
('ELEPH1','Elephant Package' ,'This package is the most popular package. It comes with the 5 most used features in telephone history. You now have voicemail included to receive messsages.', 'CID, CW, 3-Way, CF, VM', NULL, 29.99, NULL , 'Phone' ,  NULL);

Insert into PRODUCT VALUES
('BRPH1','Bear Package', 'This package is for the users that want a little more control of their telephony experience. Anonymous call rejection helps to deter unwanted solicitations from unpublished numbers.', 'CID, CW, 3-Way, ACR, RD, CF, VM',NULL,  39.99, NULL , 'Phone' ,  NULL);

Insert into PRODUCT VALUES
('CHTPH1','Cheetah Bundle'  , 'This is the most comprehensive package with all available phone features. Find me -Follow me makes its appearance for the users that want to be able to be reached no matter what. You can have the phone ring simultaneously at several different numbers.',  'CID, CW, 3-WAY, ACR, RD, RC, CF, VM, FM-FM', NULL, 44.99,NULL , 'Phone' ,  NULL);


--Insert default values for TV plans into the PRODUCT Table
Insert into PRODUCT Values
('SNLTV1', 'Snail Economy Package', 'The basic package of channels to satisfy basic television needs. Most economic option for the light user.', '35 Channels, 0 Premium Channels', NULL, 19.99 , NULL , 'TV' , NULL);

Insert into PRODUCT Values
('SQRLTV1','Squirrel Value Package ', 'This is the more in depth programming package that has more family friendly viewing and options for specialty viewers.' , '70 Channels, 0 Premium Channels', NULL, 39.99 , NULL ,  'TV' , NULL);

Insert into PRODUCT Values
('ELETV1','Elephant Standard Package', 'This is by far the most popular package. Contains most of the popular viewing channels, specialty channels, and 3 premium channels. Best value!', '135 Channels including 3 Premium Channels', NULL,  69.99 , NULL , 'TV', NULL);

Insert into PRODUCT Values
('BRTV1','Bear Bonus Package', 'This is a package for those fond of viewing variety. This package will definitely have something for everyone in the family and several things that all can enjoy together.', '299 Channels including 11 premium channels.',NULL ,89.99 , NULL, 'TV' , NULL);

Insert into PRODUCT Values
('CHTTV1','Cheetah Ultimate 500', 'This package is definitely for TV connoisseurs to enjoy. You must have a love for many programs to be able to handle all that this has to offer. It boasts a proud 500 channels of viewing joy that will have you satisfied no matter your taste in programming.', '500 Channels including 21 premium channels.', NULL, 109.99 , NULL, 'TV' , NULL);

--Insert default values for long distance plans into PRODUCT Table
INSERT INTO PRODUCT VALUES
('SNLLD1','Snail Steady 30','30 Minutes for $1. 30 cents a minute for overages.', NULL, NULL, 1 ,NULL, 'LD', .3 );

INSERT INTO PRODUCT VALUES
('SQRLD1','Squirrel Quick 60' ,'60 Minutes for $4. 15 cents a minute for overages.' , NULL, NULL,  4 , NULL , 'LD' , .15 );

INSERT INTO PRODUCT VALUES
('ELELD1','Elephant Mindful 200' , '200 Minutes for $7. 10 cents a minute for overages' ,NULL, NULL, 7 , NULL ,  'LD', .1 );

INSERT INTO PRODUCT VALUES
('BRLD1','Bear Powerful Thousand' , '1000 Minutes for $10. Nickel for overages.' ,NULL, NULL, 10 , NULL ,  'LD' ,.05);

INSERT INTO PRODUCT VALUES
('CHTLD1', 'Cheetah Unlimited' , 'Unlimited Calls', NULL, NULL, 20 , NULL , 'LD' , 0 );


--SELECT * FROM PRODUCT