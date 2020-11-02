CREATE PROCEDURE [dbo].[DeleteCustomer]
	@Id int
AS
	DELETE FROM Customer WHERE  Id = @Id