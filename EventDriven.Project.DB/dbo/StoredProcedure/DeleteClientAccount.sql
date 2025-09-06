CREATE PROCEDURE [dbo].[DeleteClientAccount]
    @ClientId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

        DELETE FROM [dbo].[Account]
        WHERE ClientId = @ClientId;

        DELETE FROM [dbo].[Client]
        WHERE Id = @ClientId;
END;
