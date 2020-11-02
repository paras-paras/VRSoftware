CREATE PROCEDURE [dbo].[GetCustomer]
	@Id int
AS
Begin
	IF @Id>0  
        BEGIN  
           select * from Customer where Id=@Id
        END  
		else	
		BEGIN 
		 select * from Customer order by CONCAT(FirstName,' ',LastName) asc
		 END 
END