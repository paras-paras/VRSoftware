CREATE PROCEDURE [dbo].[AddUpdateCustomer]
	@Id int,  
	@FirstName VARCHAR(100),  
	@LastName VARCHAR(100),  
	@Phone VARCHAR(100),  
	@Address VARCHAR(500),  
	@Date datetime,  
	@StatementType NVARCHAR(20) = ''
AS
	BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO Customer(FirstName,LastName,Phone,Address,Date)  
            VALUES (@FirstName,@LastName,@Phone,@Address,@Date )  
        END  

		IF @StatementType = 'Update'  
        BEGIN  
            UPDATE Customer  
            SET    FirstName = @FirstName,  
                   LastName = @LastName,  
                   Phone = @Phone,  
                   Address = @Address  
            WHERE  Id = @Id  
        END  
	END