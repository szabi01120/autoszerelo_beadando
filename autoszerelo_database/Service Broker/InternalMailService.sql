CREATE SERVICE [InternalMailService]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[InternalMailQueue]
    ([//www.microsoft.com/databasemail/contracts/SendMail/v1.0]);

