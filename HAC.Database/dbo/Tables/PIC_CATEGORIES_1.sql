﻿CREATE TABLE [dbo].[PIC_CATEGORIES] (
    [CAT_ID]    INT            IDENTITY (1, 1) NOT NULL,
    [CAT_NAME]  NVARCHAR (50)  NULL,
    [CAT_IMAGE] NVARCHAR (50)  NULL,
    [CAT_DESC]  NVARCHAR (255) NULL
);
