CREATE SERVICE [syspolicy_event_listener]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[syspolicy_event_queue]
    ([http://schemas.microsoft.com/SQL/Notifications/PostEventNotification]);

