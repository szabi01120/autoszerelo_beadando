CREATE ROLE [SQLAgentReaderRole]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [SQLAgentReaderRole] ADD MEMBER [SQLAgentOperatorRole];

