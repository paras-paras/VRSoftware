CREATE PROCEDURE [dbo].[DeleteRental]
	@Id int
AS
	DELETE FROM Rental WHERE  Id = @Id