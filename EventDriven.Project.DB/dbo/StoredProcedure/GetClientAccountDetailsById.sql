CREATE PROCEDURE dbo.GetClientAccountDetailsById
    @ClientId INT
AS
BEGIN
    SELECT 
        c.Id AS ClientId,
        c.Firstname,
        c.Lastname,
        c.MobileNumber,
        c.Gender,
        c.Address,
        c.Birthdate,
        a.Id AS AccountId,
        a.Balance,
        a.ModifiedDate
    FROM 
        [dbo].[Client] c
    INNER JOIN 
        [dbo].[Account] a ON c.Id = a.ClientId
    WHERE 
        (c.Id = @ClientId) 
END;