CREATE PROCEDURE [dbo].[AddUpdateVideo]
	@Id int,  
	@Title VARCHAR(500),  
	@Description VARCHAR(MAX),  
	@Genre VARCHAR(100),  
	@Cost decimal(18,2),
	@ReleaseDate datetime,  	  
	@Date datetime,  
	@StatementType NVARCHAR(20) = ''
AS
	BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO Video(Title,Description,Genre,Cost,ReleaseDate,Date)  
            VALUES (@Title,@Description,@Genre,@Cost,@ReleaseDate,@Date )  
        END  

		IF @StatementType = 'Update'  
        BEGIN  
            UPDATE Video  
            SET    Title = @Title,  
                   Description = @Description,  
                   Genre = @Genre,  
                   Cost = @Cost,  
                   ReleaseDate = @ReleaseDate  
            WHERE  Id = @Id  
        END  
	END