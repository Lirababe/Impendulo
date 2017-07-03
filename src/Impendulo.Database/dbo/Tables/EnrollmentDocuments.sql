CREATE TABLE [dbo].[EnrollmentDocuments] (
    [EnrollmentDocumentID]           INT IDENTITY (1, 1) NOT NULL,
    [EnrollmentID]                   INT NOT NULL,
    [ImageID]                        INT NOT NULL,
    [LookupEnrollmentDocumentTypeID] INT NOT NULL,
    CONSTRAINT [PK_EnrollmentDocuments] PRIMARY KEY CLUSTERED ([EnrollmentDocumentID] ASC),
    CONSTRAINT [FK_EnrollmentDocuments_Enrollments] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[Enrollments] ([EnrollmentID]),
    CONSTRAINT [FK_EnrollmentDocuments_Files] FOREIGN KEY ([ImageID]) REFERENCES [dbo].[Files] ([ImageID]),
    CONSTRAINT [FK_EnrollmentDocuments_LookupEnrollentDocumentTypes] FOREIGN KEY ([LookupEnrollmentDocumentTypeID]) REFERENCES [dbo].[LookupEnrollentDocumentTypes] ([LookupEnrollmentDocumentTypeID])
);

