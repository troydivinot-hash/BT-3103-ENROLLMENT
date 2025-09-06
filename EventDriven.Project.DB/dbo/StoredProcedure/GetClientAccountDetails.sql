CREATE PROCEDURE dbo.GetClientAccountDetails
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
        [dbo].[Client] AS c
    INNER JOIN 
        [dbo].[Account] AS a ON c.Id = a.ClientId
    ORDER BY 
        c.Id;
END;