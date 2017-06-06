CREATE TABLE [dbo].[EquiryOrigions] (
    [EnquiryID]      INT NOT NULL,
    [EquiryOriginID] INT NOT NULL,
    CONSTRAINT [PK_EquiryOrigions] PRIMARY KEY CLUSTERED ([EnquiryID] ASC, [EquiryOriginID] ASC),
    CONSTRAINT [FK_EquiryOrigions_Enquiry1] FOREIGN KEY ([EnquiryID]) REFERENCES [dbo].[Enquiry] ([EnquiryID]),
    CONSTRAINT [FK_EquiryOrigions_LookupEquiryOrigions] FOREIGN KEY ([EquiryOriginID]) REFERENCES [dbo].[LookupEquiryOrigions] ([EquiryOriginID])
);

