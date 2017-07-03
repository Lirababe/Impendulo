CREATE TABLE [dbo].[LookupEnrollentDocumentTypes] (
    [LookupEnrollmentDocumentTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [EnrollmentDocumentType]         VARCHAR (200) CONSTRAINT [DF_LookupEnrollentDocumentTypes_EnrollentDocumentType] DEFAULT ('Unknown') NOT NULL,
    CONSTRAINT [PK_LookupEnrollentDocumentTypes] PRIMARY KEY CLUSTERED ([LookupEnrollmentDocumentTypeID] ASC)
);



