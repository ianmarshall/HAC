CREATE TABLE [dbo].[Members] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [ForeName]       NVARCHAR (255) NOT NULL,
    [SurName]        NVARCHAR (255) NOT NULL,
    [Email]          NVARCHAR (255) NULL,
    [Phone]          NVARCHAR (255) NULL,
    [Password]       NVARCHAR (255) NULL,
    [DOB]            DATETIME       NULL,
    [Sex]            NVARCHAR (255) NULL,
    [Access]         NVARCHAR (255) NULL,
    [OldId]          INT            NULL,
    [MembershipType] NVARCHAR (255) NULL,
    [MembershipId]   INT            NULL,
    CONSTRAINT [PK__Member__3214EC07C20A8384] PRIMARY KEY CLUSTERED ([Id] ASC)
);

