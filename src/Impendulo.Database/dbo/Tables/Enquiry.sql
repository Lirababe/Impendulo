CREATE TABLE [dbo].[Enquiry] (
    [EnquiryID]                   INT  IDENTITY (1, 1) NOT NULL,
    [EnquiryDate]                 DATE CONSTRAINT [DF_Enquiry_EnquiryDate] DEFAULT (getdate()) NOT NULL,
    [EnquiryStatusID]             INT  CONSTRAINT [DF_Enquiry_EnquiryStatusID] DEFAULT ((1)) NOT NULL,
    [InitialConsultationComplete] BIT  CONSTRAINT [DF_Enquiry_InitialConsultationComplete] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Enquiry] PRIMARY KEY CLUSTERED ([EnquiryID] ASC),
    CONSTRAINT [FK_Enquiry_LookupEnquiryStatuses] FOREIGN KEY ([EnquiryStatusID]) REFERENCES [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID])
);











