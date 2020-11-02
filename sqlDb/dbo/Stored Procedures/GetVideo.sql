CREATE PROCEDURE [dbo].[GetVideo]
	@Id int
AS
Begin
	IF @Id>0  
        BEGIN  
           select * from Video where Id=@Id
        END  
		else	
		BEGIN 
		 select * from Video order by Title asc
		 END 
END