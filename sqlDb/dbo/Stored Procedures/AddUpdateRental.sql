CREATE PROCEDURE [dbo].[AddUpdateRental]
	@Id int,  
	@CustomerId int,  
	@VideoId int,  
	@IsReturned bit,  
	@IssuedDate datetime,
	@ReturnedDate datetime = null,  	  
	@Date datetime,  
	@StatementType NVARCHAR(20) = ''
AS
	BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO Rental(CustomerId,VideoId,IsReturned,IssuedDate,ReturnedDate,Date)  
            VALUES (@CustomerId,@VideoId,@IsReturned,@IssuedDate,@ReturnedDate,@Date )  
        END  

		IF @StatementType = 'Update'  
        BEGIN  
            UPDATE Rental  
            SET    CustomerId = @CustomerId,  
                   VideoId = @VideoId,  
                   IsReturned = @IsReturned,  
                   IssuedDate = @IssuedDate,  
                   ReturnedDate = @ReturnedDate  
            WHERE  Id = @Id  
        END  
	END 