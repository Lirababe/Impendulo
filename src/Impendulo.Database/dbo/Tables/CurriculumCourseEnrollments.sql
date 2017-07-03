﻿CREATE TABLE [dbo].[CurriculumCourseEnrollments] (
    [CurriculumCourseEnrollmentID] INT   IDENTITY (1, 1) NOT NULL,
    [CurriculumCourseID]           INT   NOT NULL,
    [EnrollmentID]                 INT   NOT NULL,
    [Excempt]                      BIT   CONSTRAINT [DF_CurriculumCourseEnrollments_Excempt] DEFAULT ((0)) NOT NULL,
    [CourseCost]                   MONEY CONSTRAINT [DF_CurriculumCourseEnrollments_CourseCost] DEFAULT ((0.00)) NOT NULL,
    CONSTRAINT [PK_CurriculumCourseEnrollments] PRIMARY KEY CLUSTERED ([CurriculumCourseEnrollmentID] ASC),
    CONSTRAINT [FK_CurriculumCourseEnrollments_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]),
    CONSTRAINT [FK_CurriculumCourseEnrollments_Enrollments1] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[Enrollments] ([EnrollmentID])
);





