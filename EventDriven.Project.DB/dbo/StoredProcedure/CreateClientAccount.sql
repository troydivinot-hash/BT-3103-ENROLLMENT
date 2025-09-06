CREATE PROCEDURE [dbo].[CreateClientAccount]
    @Firstname VARCHAR(30) = NULL,  
    @Lastname VARCHAR(30) = NULL,  
    @MobileNumber NVARCHAR(30) = NULL,  
    @Gender VARCHAR(30) = NULL,    
    @Address VARCHAR(50) = NULL,   
    @Birthdate DATETIME = NULL,    
    @Balance DECIMAL(15, 2) = NULL
AS
BEGIN
    SET NOCOUNT ON;

        INSERT INTO [dbo].[Client] (Firstname, Lastname, MobileNumber, Gender, Address, Birthdate)
        VALUES (@Firstname, @Lastname, @MobileNumber, @Gender, @Address, @Birthdate);

        DECLARE @NewClientId INT = SCOPE_IDENTITY();

        INSERT INTO [dbo].[Account] (ClientId, Balance, ModifiedDate)
        VALUES (@NewClientId, ISNULL(@Balance, 0.00), GETDATE());
END;
