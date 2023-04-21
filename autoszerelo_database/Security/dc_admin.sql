CREATE ROLE [dc_admin]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [dc_admin] ADD MEMBER [MS_DataCollectorInternalUser];

