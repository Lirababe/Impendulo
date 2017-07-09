CREATE TABLE [dbo].[StudentIDDocuments] (
    [StudentIDDocumentID] INT IDENTITY (1, 1) NOT NULL,
    [IndividualID]        INT NOT NULL,
    [ImageID]             INT NOT NULL,
    CONSTRAINT [PK_StudentIDDocuments] PRIMARY KEY CLUSTERED ([StudentIDDocumentID] ASC),
    CONSTRAINT [FK_StudentIDDocuments_Files] FOREIGN KEY ([ImageID]) REFERENCES [dbo].[Files] ([ImageID]),
    CONSTRAINT [FK_StudentIDDocuments_Students] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Students] ([IndividualID]) ON DELETE CASCADE
);



