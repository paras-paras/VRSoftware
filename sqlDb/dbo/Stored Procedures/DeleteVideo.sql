CREATE PROCEDURE [dbo].[DeleteVideo]
	@Id int
AS
	DELETE FROM Video WHERE  Id = @Id