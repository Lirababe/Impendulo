CREATE TABLE [dbo].[LookupEquiryOrigions] (
    [EquiryOriginID] INT           IDENTITY (1, 1) NOT NULL,
    [EquiryOrigin]   VARCHAR (150) NULL,
    CONSTRAINT [PK_LookupEquiryOrigions] PRIMARY KEY CLUSTERED ([EquiryOriginID] ASC)
);

