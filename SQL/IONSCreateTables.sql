--Create the Product Table
CREATE table PRODUCT
(ProductID VARCHAR(10),
Constraint pk_ProductID PRIMARY KEY (productID),
Name VARCHAR(50) NOT NULL,
Description Text NOT NULL,
Features Text,
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
Address VARCHAR(100) NOT NULL,
IsSalesperson BIT NOT NULL,
Email VARCHAR(100) NOT NULL,
Constraint uk_Email UNIQUE (Email),
UserID VARCHAR(20)
Constraint uk_UserID UNIQUE(UserID));

--Create the Salesperson Table
CREATE table SALESPERSON
(EmployeeID VARCHAR(10),
SalesID VARCHAR(10),
Constraint pk_EmployeeID_SalesID PRIMARY KEY (SalesID),
Constraint fk_EmployeeID_Salesperson FOREIGN KEY (EmployeeID)
References EMPLOYEE (EmployeeID));


--CREATE The Customer Table
CREATE Table CUSTOMER
(Customer# Numeric(10),
CONSTRAINT pk_customer# Primary Key (customer#),
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
MiddleName VARCHAR(20),
Address VARCHAR(100) NOT NULL,
Zip NUMERIC(5) NOT NULL,
City VARCHAR(25) NOT NULL,
State VARCHAR(2) NOT NULL,
SSN Numeric(9) NOT NULL,
CONSTRAINT uk_SSN_Customer UNIQUE (SSN),
DOB date NOT NULL,
ContactNumber NUMERIC(15), 
DateEst date NOT NULL,
Balance Numeric(10,2) NOT NULL,
WasReferred BIT NOT NULL,
Referral# Numeric(10),
CONSTRAINT fk_Referral#_Customer# Foreign Key (Referral#)
References CUSTOMER (Customer#),
Email VARCHAR(100),
SalesID VARCHAR(10));
--Constraint fk_SalesID_Customer FOREIGN KEY (SalesID) 
--REFERENCES SALESPERSON (SalesID));

--Create the INVOICE Table
Create Table INVOICE
(InvoiceID VARCHAR(10),
Constraint pk_InvoiceID PRIMARY KEY (InvoiceID),
Total Numeric(8,2) NOT NULL,
InvoiceDate Date NOT NULL,
Customer# Numeric(10),
Constraint fk_customer#_Invoice FOREIGN KEY (Customer#)
References CUSTOMER (Customer#));

--Create Table INVOICEDPRODUCT

CREATE Table INVOICEDPRODUCT
(InvoiceID VARCHAR(10) ,
ProductID VARCHAR(10),
Constraint fk_InvoiceID_InvoicedProduct FOREIGN KEY (InvoiceID)
References INVOICE (InvoiceID),
Constraint fk_ProductID_InvoicedProduct FOREIGN KEY (ProductID)
References PRODUCT (ProductID),
Constraint pk_InvoiceID_productID_InvoicedProduct PRIMARY KEY (InvoiceID, ProductID));

--CREATE TABLE CUSTOMERSPRODUCT

CREATE TABLE CUSTOMERSPRODUCT
(Customer# NUMERIC(10) ,
ProductID VARCHAR(10),
Constraint fk_CustomerID_SelectedProduct FOREIGN KEY (Customer#)
References CUSTOMER (Customer#),
Constraint fk_ProductID_SelectedProduct FOREIGN KEY (ProductID)
References PRODUCT (ProductID),
Constraint pk_InvoiceID_productID_SelectedProduct PRIMARY KEY (Customer#, ProductID));

--CREATE ORDERS TABLE 
CREATE TABLE ORDERS
(Order# VARCHAR(10),
Constraint pk_Order#_Orders PRIMARY KEY (Order#),
Status VARCHAR(1),
DueDate Date NOT NULL,
Customer# NUMERIC(10) ,
Constraint fk_CustomerID_Orders FOREIGN KEY (Customer#)
References CUSTOMER (Customer#),
EmployeeID VARCHAR(10),
Constraint fk_EmployeeID_Orders FOREIGN KEY (EmployeeID)
References EMPLOYEE (EmployeeID));

--Create table ORDEREDPRODUCT
CREATE TABLE ORDEREDPRODUCT
(Order# VARCHAR(10) ,
ProductID VARCHAR(10),
Constraint fk_Order#_SelectedProduct FOREIGN KEY (Order#)
References ORDERS (Order#),
Constraint fk_ProductID_OrderProduct FOREIGN KEY (ProductID)
References PRODUCT (ProductID),
Constraint pk_Order#_productID_OrderedProduct PRIMARY KEY (Order#, ProductID));

--drop table ORDEREDPRODUCT;
--drop table orders;
--drop table CUSTOMERSPRODUCT;
--drop table invoicedproduct;
--drop table invoice;
--drop table customer;
--drop table salesperson;
--drop table employee;
--drop table product;


