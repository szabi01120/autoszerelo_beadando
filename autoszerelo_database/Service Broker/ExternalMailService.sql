CREATE SERVICE [ExternalMailService]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[ExternalMailQueue]
    ([//www.microsoft.com/databasemail/contracts/SendMail/v1.0]);

