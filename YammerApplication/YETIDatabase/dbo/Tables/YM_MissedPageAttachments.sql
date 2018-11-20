﻿CREATE TABLE [dbo].[YM_MissedPageAttachments] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [pageId]      BIGINT         NULL,
    [pageName]    NVARCHAR (MAX) NULL,
    [threadId]    BIGINT         NULL,
    [groupId]     BIGINT         NULL,
    [groupName]   NVARCHAR (MAX) NULL,
    [csvfilename] NVARCHAR (MAX) NULL,
    [status]      NVARCHAR (200) NULL,
    [timesTried]  INT            NULL,
    [UploadedAt]  DATETIME       NULL,
    [DeletedAt]   DATETIME       NULL,
    [ProcessedBy] NVARCHAR (200) NULL
);

