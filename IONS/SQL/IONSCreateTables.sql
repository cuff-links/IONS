--Create the Product Table
CREATE table PRODUCT
(ProductID VARCHAR(10),
Constraint pk_ProductID PRIMARY KEY (productID),
Name VARCHAR(50) NOT NULL,
Description Text NOT NULL,
Features Text,
RelatedTelephone# VARCHAR(15),
Price Numeric(8,2) NOT NULL,
Technology VARCHAR(50),
Category VARCHAR(25),
PerMinute Numeric(4,2));

--Create the EMPLOYEE Table
CREATE table EMPLOYEE
(EmployeeID VARCHAR(10),
Constraint pk_EmployeeID PRIMARY KEY (EmployeeID),
FirstName VARCHAR(20) NOT NULL,
MiddleInit VARCHAR(1),
LastName VARCHAR(20) NOT NULL,
IsSalesperson BIT NOT NULL,
Email VARCHAR(100) NOT NULL,
Constraint uk_Email UNIQUE (Email),
UserID VARCHAR(20)
Constraint uk_UserID UNIQUE(UserID));


--CREATE The CLIENT Table
CREATE Table CLIENT
(Client# VARCHAR(10),
CONSTRAINT pk_Client# Primary Key (Client#),
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
MiddleName VARCHAR(20),
Address VARCHAR(100) NOT NULL,
Zip NUMERIC(5) NOT NULL,
City VARCHAR(25) NOT NULL,
State VARCHAR(2) NOT NULL,
SSN VARCHAR(9) NOT NULL,
CONSTRAINT uk_SSN_Customer UNIQUE (SSN),
DOB date NOT NULL,
ContactNumber VARCHAR(10), 
DateEst date NOT NULL,
Balance Numeric(10,2) NOT NULL,
WasReferred BIT NOT NULL,
Referral# VARCHAR(10),
Email VARCHAR(100),
SalesID VARCHAR(10));

--Create the INVOICE Table
Create Table INVOICE
(InvoiceID VARCHAR(10),
Constraint pk_InvoiceID PRIMARY KEY (InvoiceID),
Total Numeric(8,2) NOT NULL,
InvoiceDate Date NOT NULL,
Client# VARCHAR(10),
Constraint fk_customer#_Invoice FOREIGN KEY (Client#)
References CLIENT (Client#)
ON DELETE CASCADE
ON UPDATE CASCADE);

--Create Table INVOICEDPRODUCT

CREATE Table INVOICEDPRODUCT
(InvoiceID VARCHAR(10) ,
ProductID VARCHAR(10),
Constraint fk_InvoiceID_InvoicedProduct FOREIGN KEY (InvoiceID)
References INVOICE (InvoiceID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Constraint fk_ProductID_InvoicedProduct FOREIGN KEY (ProductID)
References PRODUCT (ProductID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Constraint pk_InvoiceID_productID_InvoicedProduct PRIMARY KEY (InvoiceID, ProductID));

--CREATE TABLE CLIENTSSPRODUCT

CREATE TABLE CLIENTSPRODUCT
(Client# VARCHAR(10) ,
ProductID VARCHAR(10),
Constraint fk_Client#_ClientsProduct FOREIGN KEY (Client#)
References CLIENT (Client#)
ON DELETE CASCADE
ON UPDATE CASCADE,
Constraint fk_ProductID_ClientsProduct FOREIGN KEY (ProductID)
References PRODUCT (ProductID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Constraint pk_Client#_productID_Clientsroduct PRIMARY KEY (Client#, ProductID));

--CREATE ORDERS TABLE 
CREATE TABLE ORDERS
(Order# VARCHAR(10),
Constraint pk_Order#_Orders PRIMARY KEY (Order#),
Status VARCHAR(1),
DueDate Date NOT NULL,
Client# VARCHAR(10) ,
Constraint fk_Client#_Orders FOREIGN KEY (Client#)
References CLIENT (Client#),
Comments TEXT,
EmployeeID VARCHAR(10),
Constraint fk_EmployeeID_Orders FOREIGN KEY (EmployeeID)
References EMPLOYEE (EmployeeID)
ON DELETE CASCADE
ON UPDATE CASCADE);

--Create table ORDEREDPRODUCT
CREATE TABLE ORDEREDPRODUCT
(Order# VARCHAR(10) ,
ProductID VARCHAR(10),
Constraint fk_Order#_OrderedProduct FOREIGN KEY (Order#)
References ORDERS (Order#)
ON DELETE CASCADE
ON UPDATE CASCADE,
Constraint fk_ProductID_OrderedProduct FOREIGN KEY (ProductID)
References PRODUCT (ProductID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Constraint pk_Order#_productID_OrderedProduct PRIMARY KEY (Order#, ProductID));

--Create unique nonclustered index for order# so many orderedproducts can share an order#
CREATE UNIQUE NONCLUSTERED INDEX [IX_DupIndex_ProductID]
ON dbo.ORDEREDPRODUCT
(
ProductID , Order# ASC
) WITH (IGNORE_DUP_KEY = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_DupIndex_ProductID]
ON dbo.CLIENTSPRODUCT
(
ProductID , Client# ASC
) WITH (IGNORE_DUP_KEY = ON) ON [PRIMARY]
GO

--drop table ORDEREDPRODUCT;
--drop table ORDERS;
--drop table CLIENTSPRODUCT;
--drop table INVOICEDPRODUCT;
--drop table INVOICE;
--drop table CLIENT;
--drop table SALESPERSON;
--drop table EMPLOYEE;
--drop table PRODUCT;


