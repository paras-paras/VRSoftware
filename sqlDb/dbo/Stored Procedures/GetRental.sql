CREATE PROCEDURE [dbo].[GetRental]
	@Id int
AS
Begin
	IF @Id>0  
        BEGIN  
           select * from Rental where Id=@Id
        END  
		else	
		BEGIN 
		 select * from Rental order by IssuedDate asc
		 END 
END