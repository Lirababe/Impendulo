CREATE TABLE [dbo].[CurriculumCourseEnrollments] (
    [CurriculumCourseEnrollmentID]    INT   IDENTITY (1, 1) NOT NULL,
    [CurriculumCourseID]              INT   NOT NULL,
    [EnrollmentID]                    INT   NOT NULL,
    [LookupEnrollmentProgressStateID] INT   CONSTRAINT [DF_CurriculumCourseEnrollments_LookupEnrollmentProgressStateID] DEFAULT ((2002)) NOT NULL,
    [CourseCost]                      MONEY CONSTRAINT [DF_CurriculumCourseEnrollments_CourseCost] DEFAULT ((0.00)) NOT NULL,
    CONSTRAINT [PK_CurriculumCourseEnrollments] PRIMARY KEY CLUSTERED ([CurriculumCourseEnrollmentID] ASC),
    CONSTRAINT [FK_CurriculumCourseEnrollments_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]),
    CONSTRAINT [FK_CurriculumCourseEnrollments_Enrollments1] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[Enrollments] ([EnrollmentID]),
    CONSTRAINT [FK_CurriculumCourseEnrollments_LookupEnrollmentProgressStates] FOREIGN KEY ([LookupEnrollmentProgressStateID]) REFERENCES [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID])
);







