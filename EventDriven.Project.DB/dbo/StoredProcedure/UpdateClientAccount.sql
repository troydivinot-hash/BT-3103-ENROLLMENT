CREATE PROCEDURE [dbo].[UpdateClientAccount]
    @ClientId INT = NULL,      
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
        UPDATE [dbo].[Client]
        SET Firstname = @Firstname,
            Lastname = @Lastname,
            MobileNumber = @MobileNumber,
            Gender = @Gender,
            Address = @Address,
            Birthdate = @Birthdate
        WHERE Id = @ClientId;

        UPDATE [dbo].[Account]
        SET Balance = ISNULL(@Balance, 0.00),
            ModifiedDate = GETDATE()
        WHERE ClientId = @ClientId;
    
END;
