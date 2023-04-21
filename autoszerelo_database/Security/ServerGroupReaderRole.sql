CREATE ROLE [ServerGroupReaderRole]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [ServerGroupReaderRole] ADD MEMBER [ServerGroupAdministratorRole];

