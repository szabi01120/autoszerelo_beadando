CREATE ROLE [db_ssisoperator]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [db_ssisoperator] ADD MEMBER [dc_operator];


GO
ALTER ROLE [db_ssisoperator] ADD MEMBER [dc_proxy];


GO
ALTER ROLE [db_ssisoperator] ADD MEMBER [MS_DataCollectorInternalUser];

