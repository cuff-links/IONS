ALTER PROCEDURE dbo.CompleteOrder
(
	@OrderNumber VARCHAR(10)
)
AS
BEGIN TRANSACTION

Insert into CLIENTSPRODUCT
SELECT        o.Client#, op.ProductID
FROM            ORDERS o INNER JOIN
                         ORDEREDPRODUCT  op ON o.Order# = op.Order#
WHERE        (o.Order# = @OrderNumber)


IF @@ERROR <> 0
	BEGIN
		-- Rollback the transaction
		ROLLBACK

		-- Raise an error and return
		RAISERROR ('Error in inserting PRODUCTS INTO CLIENTSPRODUCT table.', 16, 1)
		RETURN
	END	
	
--All inserts have succeeded if we have gotten to this point. Commit transaction. 
COMMIT
