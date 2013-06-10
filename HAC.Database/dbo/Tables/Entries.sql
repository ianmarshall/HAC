CREATE TABLE [dbo].[Entries] (
    [EntryId]       INT            IDENTITY (1, 1) NOT NULL,
    [Race]          BIT            NOT NULL,
    [First_Name]    NVARCHAR (MAX) NOT NULL,
    [Last_Name]     NVARCHAR (MAX) NOT NULL,
    [Address_Line1] NVARCHAR (MAX) NOT NULL,
    [Address_Line2] NVARCHAR (MAX) NOT NULL,
    [CityTown]      NVARCHAR (MAX) NOT NULL,
    [County]        NVARCHAR (MAX) NOT NULL,
    [Phone]         NVARCHAR (MAX) NOT NULL,
    [Email]         NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.Entries] PRIMARY KEY CLUSTERED ([EntryId] ASC)
);

