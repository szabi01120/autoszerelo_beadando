CREATE TYPE [dbo].[syspolicy_target_filters_type] AS TABLE (
    [target_filter_id] INT            NULL,
    [policy_id]        INT            NULL,
    [type]             [sysname]      NOT NULL,
    [filter]           NVARCHAR (MAX) NOT NULL,
    [type_skeleton]    [sysname]      NOT NULL);

