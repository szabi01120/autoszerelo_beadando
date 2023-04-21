CREATE ROLE [dc_operator]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [dc_operator] ADD MEMBER [dc_admin];

