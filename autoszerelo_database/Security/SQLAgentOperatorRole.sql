CREATE ROLE [SQLAgentOperatorRole]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [SQLAgentOperatorRole] ADD MEMBER [PolicyAdministratorRole];

