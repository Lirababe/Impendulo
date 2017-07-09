CREATE TABLE [dbo].[VenueAssociatedCourses] (
    [VenueAssociatedCourseID] INT IDENTITY (1, 1) NOT NULL,
    [CourseID]                INT NOT NULL,
    [VenueID]                 INT NOT NULL,
    [VenueMaxCapacity]        INT CONSTRAINT [DF_VenueAssociatedCourses_VenueMaxCapacity] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_VenueAssociatedCourses] PRIMARY KEY CLUSTERED ([VenueAssociatedCourseID] ASC),
    CONSTRAINT [FK_VenueAssociatedCourses_Courses] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Courses] ([CourseID]),
    CONSTRAINT [FK_VenueAssociatedCourses_Venues] FOREIGN KEY ([VenueID]) REFERENCES [dbo].[Venues] ([VenueID]) ON DELETE CASCADE
);



