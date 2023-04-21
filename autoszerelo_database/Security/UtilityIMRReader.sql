CREATE ROLE [UtilityIMRReader]
    AUTHORIZATION [dbo];


GO
ALTER ROLE [UtilityIMRReader] ADD MEMBER [UtilityIMRWriter];

