CREATE TABLE [dbo].[StudentPhotos] (
    [StudentPhotoID] INT      IDENTITY (1, 1) NOT NULL,
    [IndividualID]   INT      NOT NULL,
    [ImageID]        INT      NOT NULL,
    [DateUpdated]    DATETIME CONSTRAINT [DF_StudentPhotos_DateUpdated] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_StudentPhotos] PRIMARY KEY CLUSTERED ([StudentPhotoID] ASC),
    CONSTRAINT [FK_StudentPhotos_Files] FOREIGN KEY ([ImageID]) REFERENCES [dbo].[Files] ([ImageID]) ON DELETE CASCADE,
    CONSTRAINT [FK_StudentPhotos_Students] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Students] ([IndividualID]) ON DELETE CASCADE
);



