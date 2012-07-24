SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[CreateEmployee]
(
	@FirstName VARCHAR(20),
	@MiddleInit VARCHAR(1),
	@LastName VARCHAR(20),
	@IsSalesperson BIT,
	@Email VARCHAR(100),
	@UserID VARCHAR(10)
)
AS

BEGIN TRANSACTION
--Declare employeeID and set to a random number
Declare @EmployeeID VARCHAR(10)
SET @EmployeeID = (CAST(CAST( RAND() * 10000000000 as BIGINT) as VARCHAR))

--If N/A was passed as a parameter, set MiddleInit to NULL
IF (@MiddleInit = 'N/A')
BEGIN 
	SET @MiddleInit = NULL
END

--Check if EmployeeID exists in the Employee Table. If so, set to new random number.
WHILE( EXISTS(SELECT TOP 1 * from EMPLOYEE WHERE EmployeeID = @EmployeeID))
	BEGIN
		SET @EmployeeID = (CAST(CAST( RAND() * 10000000000 as BIGINT) as VARCHAR))	
	END


--Insert values into database. 
INSERT INTO EMPLOYEE VALUES
(@EmployeeID, @FirstName,@MiddleInit, @LastName, @IsSalesperson, @Email, @UserID)

IF @@ERROR <> 0
	BEGIN
		-- Rollback the transaction
		ROLLBACK

		-- Raise an error and return
		RAISERROR ('Error in inserting employee  into Employee table.', 16, 1)
		RETURN
	END	
	
--All inserts have succeeded if we have gotten to this point. Commit transaction. 
COMMIT